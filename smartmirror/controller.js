(function (angular) {



    function MirrorCtrl(
        AnnyangService,
        GeolocationService,
        WeatherService,
        MapService,
        TrafficService,
        SubwayService,
        $scope, $timeout, $interval, $sce, $http) {

        var apiKey = "AIzaSyBOGIMF2Ri8tQHXIGSkAcouzaSdePrDQ_U";
        var _this = this;
        var command = COMMANDS.ko;
        var functionService = FUNCTIONSERVICE;
        var DEFAULT_COMMAND_TEXT = command.default;
        var PHOTO_INDEX = 0;
        var VIDEO_INDEX = 0;
        $scope.listening = false;
        $scope.complement = command.hi;
        $scope.debug = false;
        $scope.focus = "default";
        $scope.greetingHidden = "true";
        $scope.user = {};
        $scope.interimResult = DEFAULT_COMMAND_TEXT;

        /** Smart Mirror IP */
        var os = require('os');
        var networkInterfaces = os.networkInterfaces();
        $scope.ipAddress = networkInterfaces.eth0[0].address;
        console.log("ip:" + $scope.ipAddress);

        //var client = require('@google-cloud/speech');
        // Update the time
        function updateTime() {
            $scope.date = new Date();
        }

        // Reset the command text
        var restCommand = function () {
            $scope.interimResult = DEFAULT_COMMAND_TEXT;
        }

        _this.init = function () {


            //****************************음성인식**************************************************
            //************************************************************************************* 
            $scope.recognize = function () {
                $http.get("http://localhost:9000/recognize").then(function (res) {
                    console.log(res);
                    var res_command = res.data + "";
                    $scope.interimResult = res_command; // 미러의 음성인식된 문구에 보여짐
                    console.log("res Command :: " + res_command);


                    console.log(res_command);
                    if (res_command === command.sleep) { functionService.goSleep($scope); }
                    else if (res_command === command.whois) { functionService.whoIsSmartMirror($scope); }
                    else if (res_command === command.home) { functionService.defaultHome($scope); }
                    else if (res_command === command.wake) { functionService.wake($scope); }
                    else if (res_command === command.whatcanisay) { functionService.whatCanISay($scope); }
                    else if (res_command === command.map) { functionService.map($scope, GeolocationService, MapService); }
                    //else if(res_command === command.traffic){ TrafficService.getTravelDuration(); }
                    

                    //*********************대중교통 길찾기 실행*******************************
                    //********************************************************************** 
                    var endPointExist = res_command.indexOf("길");
                    if (endPointExist != -1) {
                        var recogEndPoint = res_command.split(" 가는");
                        console.log(recogEndPoint);
                        var encodeEndPoint = encodeURI(recogEndPoint[0]);
                        console.log(encodeEndPoint);
                        $http("https://maps.googleapis.com/maps/api/geocode/json?address=" + encodeEndPoint
                            + "&key=AIzaSyBOGIMF2Ri8tQHXIGSkAcouzaSdePrDQ_U").then(function (response) {
                                console.log(responce);
                                var resultData = {
                                    "name": res.data.result.address_components.short_name,
                                    "lat": res.data.result.geometry.location.lat,
                                    "lng": res.data.result.geometry.location.lng
                                };
                                TrafficService.getTravelDuration(resultData);
                            }, function (err) { console.log(err); });
                    }
                    //***************************************************************************
                    //***************************************************************************


                    /* Map Service ***의 위치 보여줘 */
                    var locationExist = res_command.indexOf("위치");
                    if (locationExist != -1) {
                        var locationValue = res_command.split("위치");
                        console.log(locationValue[0]);
                        functionService.location(locationValue[0], $scope, GeolocationService, MapService);
                    }
                    /* 지하철 **역 *호선 *행성 */
                    var subwayExist = res_command.indexOf("역");
                    if (subwayExist != -1) {
                        // OO역 OO호선 상(하)행선
                        var temp1 = res_command.split("역");
                        var temp2 = temp1[1].split("호선");

                        var subwayStation = temp1[0];
                        var subwayLineNumber = temp2[0].trim();
                        var subwayUpDown = temp2[1].trim();
                        console.log(subwayStation + "역" + subwayLineNumber + "호선" + subwayUpDown);
                        functionService.subway(subwayStation, subwayLineNumber, subwayUpDown, $scope, SubwayService);
                    }

                }, function (error) { });
            }








            $scope.map = MapService.generateMap("Seoul,Korea");
            var tick = $interval(updateTime, 1000); // 1초 마다
            //    updateTime();




            /** GPS 정보를 가져온다 */
            GeolocationService.getLocation({ enableHighAccuracy: true }).then(function (geoposition) {
                console.log("Geoposition", geoposition);
                $scope.map = MapService.generateMap(geoposition.coords.latitude + ',' + geoposition.coords.longitude);
            });
            restCommand();

            /** 현재 장소를 가져오며, 날씨 정보를 가져온다. */
            var refreshMirrorData = function () {
                //Get our location and then get the weather for our location
                GeolocationService.getLocation({ enableHighAccuracy: true }).then(function (geoposition) {
                    console.log("Geoposition", geoposition);
                    WeatherService.init(geoposition).then(function () {
                        $scope.currentForcast = WeatherService.currentForcast();
                        $scope.weeklyForcast = WeatherService.weeklyForcast();
                        $scope.hourlyForcast = WeatherService.hourlyForcast();
                        console.log("Current", $scope.currentForcast);
                        console.log("Weekly", $scope.weeklyForcast);
                        console.log("Hourly", $scope.hourlyForcast);
                    });
                }, function (error) {
                    console.log(error);
                });


                /** config.js의 greeting 배열(인사말의 정보)를 랜덤으로 가져온다 */
                $scope.greeting = config.greeting[Math.floor(Math.random() * config.greeting.length)];
            };

            refreshMirrorData();
            $interval(refreshMirrorData, 3600000);

            //  $interval(refreshTrafficData, config.traffic.reload_interval * 6000000000);

            /* Default뷰는 홈 화면*/
            var defaultView = function () {
                functionService.defaultHome($scope);
            }

            // 미러는 누구니
            AnnyangService.addCommand(command.whois, function () {
                functionService.whoIsSmartMirror($scope);
            });

            // 사용가능한 명령을 보여준다.
            AnnyangService.addCommand(command.whatcanisay, function () {
                functionService.whatCanISay($scope);
            });

            // 홈화면으로
            AnnyangService.addCommand(command.home, defaultView);

            // 미러의 화면을 끈다.
            AnnyangService.addCommand(command.sleep, function () {
                functionService.goSleep($scope);
            });

            // 미러의 화면을 켠다.
            AnnyangService.addCommand(command.wake, function () {
                functionService.wake($scope);
            });

            // 디버그의 정보를 보여준다.
            AnnyangService.addCommand(command.debug, function () {
                console.debug("Boop Boop. Showing debug info...");
                $scope.debug = true;
            });

            // 현재 위치의 지도를 보여준다.
            AnnyangService.addCommand(command.map, function () {
                functionService.map($scope, GeolocationService, MapService);
            });

            // 특정 위치의 지도를 보여준다.
            AnnyangService.addCommand(command.locaiton, function (location) {
                console.debug("Getting map of", location);
                $scope.map = MapService.generateMap(location);
                $scope.focus = "map";
            });

            // 지도를 확대한다.
            AnnyangService.addCommand(command.zoomin, function () {
                console.debug("Zoooooooom!!!");
                $scope.map = MapService.zoomIn();
            });

            // 지도를 축소한다.
            AnnyangService.addCommand(command.zoomout, function () {
                console.debug("Moooooooooz!!!");
                $scope.map = MapService.zoomOut();
            });

            // 지도의 줌 값을 정한다. 
            AnnyangService.addCommand(command.zoomvalue, function (value) {
                console.debug("Moooop!!!", value);
                $scope.map = MapService.zoomTo(value);
            });

            // 지도의 줌 값을 리셋 한다.
            AnnyangService.addCommand(command.zoomreset, function () {
                console.debug("Zoooommmmmzzz00000!!!");
                $scope.map = MapService.reset();
                $scope.focus = "map";
            });

            /** Subway */
            // 지하철 도착 정보 
            AnnyangService.addCommand(command.subway, function (station, linenumber, updown) {
                SubwayService.init(station).then(function () {
                    SubwayService.getArriveTime(linenumber, updown).then(function (data) {
                        if (data != null) {
                            $scope.subwayinfo1 = data[1].ARRIVETIME + "에 " + data[1].SUBWAYNAME + "행 열차";
                            $scope.subwayinfo2 = data[2].ARRIVETIME + "에 " + data[2].SUBWAYNAME + "행 열차";
                            $scope.subwayinfo3 = data[3].ARRIVETIME + "에 " + data[3].SUBWAYNAME + "행 열차";
                            $scope.subwayinfo4 = data[4].ARRIVETIME + "에 " + data[4].SUBWAYNAME + "행 열차";

                            if (responsiveVoice.voiceSupport()) {
                                responsiveVoice.speak(data[1].ARRIVETIME + "에 " + data[1].SUBWAYNAME + "행 열차가 있습니다. 이어서," + data[2].ARRIVETIME + "에 " + data[2].SUBWAYNAME + "행 열차가 있습니다.", "Korean Female");
                            }
                        } else {
                            $scope.subwayinfo = "운행하는 열차가 존재 하지 않습니다.";
                        }
                        $scope.focus = "subway";
                    });
                });
            });
            $scope.interimResult = DEFAULT_COMMAND_TEXT; // 미러의 음성인식된 문구에 보여짐
        };

        _this.init();


    }

    angular.module('SmartMirror')
        .controller('MirrorCtrl', MirrorCtrl);

}(window.angular));
