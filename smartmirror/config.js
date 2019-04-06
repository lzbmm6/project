var config = {
    // Language for the mirror (currently not implemented)
    language : "ko",
    greeting : [""], // An array of greetings to randomly choose from

	//geolocation
	geo_position: {
		latitude:36.351274,
		longitude: 127.422347
	},
	
	// forcast.io
    forcast : {
        key : "6930e58d3ba828a589e6fbc54c7f26b7", // Your forcast.io api key
        units : "auto" // See forcast.io documentation if you are getting the wrong units
    },
    // Calendar (An array of iCals)
    calendar: {
      icals : ["7e8b684e80264c77aa50807c6bea572e65ede684"],
      maxResults: 9, // Number of calender events to display (Defaults is 9)
      maxDays: 365 // Number of days to display (Default is one year)
    },
    traffic: {
      key : "dZSsFvFoOPmmszhJh+66T0Vlb6ObhNniwwOj+2z43bw", //odsay  API Key
      mde : "Transit", // Possibilities: Driving / Transit / Walking

 


    },


    subway: {
      key:"....."
    },
}
