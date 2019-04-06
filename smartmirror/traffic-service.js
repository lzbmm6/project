(function () {
  'use strict';

  function TrafficService($http, $q) {
    var service = {};
    var duration = null;
    var ODsay = "https://api.odsay.com/v1/api/searchBusLane?";
    var sx = 127.42256;     //출발 기본 값 한남대
    var sy = 36.35069;      //
    var startID = 366505;   //한남대학교 정류장 id

    service.getTravelDuration = function (result) {
      var deferred = $q.defer();
      var key = "dZSsFvFoOPmmszhJh%2B66T0Vlb6ObhNniwwOj%2B2z43bw";
      console.log(result);


      $http.get("https://api.odsay.com/v1/api/searchPubTransPath?lang=0&EX=" + result.lng + "&EY=" + result.lat + "&OPT=0&apiKey=" + key)
        .then(function (responase) {
          var resultPath = response.data.result.path;

          //출발 정류장이 한남대인 경로 검색
          for (var i = 0; i < resultPath.length; i++) {
            if (resultPath[i].subPath[2].startID === 366505) {
              resultPath = resultPath[i].subPath;
            }
          }
          console.log(resultPath);


          //길찾기 결과 음성 출력 멘트 생성
          var resultMent = result.address_components.short_name + " 가는 최단경로를 안내합니다  ";
          if((resultPath.info.busTransitCount+resultPath.info.subwayTransitCount)>1){
            resultMent += "환승하는 경로입니다.    현재 정류장에서";
          }
          
          // var transitcount = resultPath.info.busTransitCount + resultPath.info.subwayTransitCount;
          for (var i = 0; i < resultPath.length; i++) {
            if (resultPath[i].trafficType === 2) {
              resultMent += resultPath[1].lane[0].busNo + "  번 버스 승차    "
                + resultPath[1].passStopList.stations.length + "  개  정류장을 지나 "
                + resultPath[1].endName + " 정류장 하차   ";
            } else if (resultPath[i].trafficType === 1) {
              resultMent += resultPath[1].lane[0].subwayNo + " 호선 지하철 승차    "
                + resultPath[1].passStopList.stations.length + "  개  정류장을 지나 "
                + resultPath[1].endName + " 정류장 하차   ";
            } else { continue; }
          }
          console.log(resultMent);
          if (responsiveVoice.voiceSupport()) {
            responsiveVoice.speak(resultMent, "Korean Female");
          }
        }, function (error) {
          if (error.status === 404) {
            console.error('No transit information available between start and end');
            deferred.reject('Unavailable');
          } else {
            console.error(error.statusText);
            deferred.reject('Unknown error');
          }
          duration = deferred.promise;
        });
      return deferred.promise;
    };

    return service;
  }

  angular.module('SmartMirror')
    .factory('TrafficService', TrafficService);

}());
