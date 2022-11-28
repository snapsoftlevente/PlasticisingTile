// This file can be replaced during build by using the `fileReplacements` array.
// `ng build` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.

export const environment = {
  production: false,
  apiRootUrl: 'http://localhost:8080',
  emptyChartMessage: "Please choose at least {0} aggregation(s) and {1} column(s)!",
  minimumAggregations: 1,
  minimumColumns: 3,
  polarChartOptions: {  
    chart: {
      polar: true,
      type: 'line'
    },
    title: {
      text: 'Compare plasticising molding machines'
    },
    xAxis: {
      tickmarkPlacement: 'on',
      lineWidth: 0,  
    },
    yAxis: {
      gridLineInterpolation: 'polygon',
      min: 0
    }
  }
};

/*
 * For easier debugging in development mode, you can import the following file
 * to ignore zone related error stack frames such as `zone.run`, `zoneDelegate.invokeTask`.
 *
 * This import should be commented out in production mode because it will have a negative impact
 * on performance if an error is thrown.
 */
// import 'zone.js/plugins/zone-error';  // Included with Angular CLI.
