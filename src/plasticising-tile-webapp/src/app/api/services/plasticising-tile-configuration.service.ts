/* tslint:disable */
/* eslint-disable */
import { Injectable } from '@angular/core';
import { HttpClient, HttpResponse, HttpContext } from '@angular/common/http';
import { BaseService } from '../base-service';
import { ApiConfiguration } from '../api-configuration';
import { StrictHttpResponse } from '../strict-http-response';
import { RequestBuilder } from '../request-builder';
import { Observable } from 'rxjs';
import { map, filter } from 'rxjs/operators';

import { PlasticisingTileConfigurationDto } from '../models/plasticising-tile-configuration-dto';
import { PlasticisingTileConfigureRequestDto } from '../models/plasticising-tile-configure-request-dto';
import { PlasticisingTileDto } from '../models/plasticising-tile-dto';

@Injectable({
  providedIn: 'root',
})
export class PlasticisingTileConfigurationService extends BaseService {
  constructor(
    config: ApiConfiguration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * Path part for operation apiPlasticisingTileConfigurationGet
   */
  static readonly ApiPlasticisingTileConfigurationGetPath = '/api/plasticising-tile-configuration';

  /**
   * Retrieves plasticising tile default configuration.
   *
   * Sample request:
   *             
   *     GET /plasticising-tile-configuration
   *
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiPlasticisingTileConfigurationGet$Plain()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiPlasticisingTileConfigurationGet$Plain$Response(params?: {
    context?: HttpContext
  }
): Observable<StrictHttpResponse<PlasticisingTileConfigurationDto>> {

    const rb = new RequestBuilder(this.rootUrl, PlasticisingTileConfigurationService.ApiPlasticisingTileConfigurationGetPath, 'get');
    if (params) {
    }

    return this.http.request(rb.build({
      responseType: 'text',
      accept: 'text/plain',
      context: params?.context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return r as StrictHttpResponse<PlasticisingTileConfigurationDto>;
      })
    );
  }

  /**
   * Retrieves plasticising tile default configuration.
   *
   * Sample request:
   *             
   *     GET /plasticising-tile-configuration
   *
   * This method provides access to only to the response body.
   * To access the full response (for headers, for example), `apiPlasticisingTileConfigurationGet$Plain$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiPlasticisingTileConfigurationGet$Plain(params?: {
    context?: HttpContext
  }
): Observable<PlasticisingTileConfigurationDto> {

    return this.apiPlasticisingTileConfigurationGet$Plain$Response(params).pipe(
      map((r: StrictHttpResponse<PlasticisingTileConfigurationDto>) => r.body as PlasticisingTileConfigurationDto)
    );
  }

  /**
   * Retrieves plasticising tile default configuration.
   *
   * Sample request:
   *             
   *     GET /plasticising-tile-configuration
   *
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiPlasticisingTileConfigurationGet$Json()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiPlasticisingTileConfigurationGet$Json$Response(params?: {
    context?: HttpContext
  }
): Observable<StrictHttpResponse<PlasticisingTileConfigurationDto>> {

    const rb = new RequestBuilder(this.rootUrl, PlasticisingTileConfigurationService.ApiPlasticisingTileConfigurationGetPath, 'get');
    if (params) {
    }

    return this.http.request(rb.build({
      responseType: 'json',
      accept: 'text/json',
      context: params?.context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return r as StrictHttpResponse<PlasticisingTileConfigurationDto>;
      })
    );
  }

  /**
   * Retrieves plasticising tile default configuration.
   *
   * Sample request:
   *             
   *     GET /plasticising-tile-configuration
   *
   * This method provides access to only to the response body.
   * To access the full response (for headers, for example), `apiPlasticisingTileConfigurationGet$Json$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiPlasticisingTileConfigurationGet$Json(params?: {
    context?: HttpContext
  }
): Observable<PlasticisingTileConfigurationDto> {

    return this.apiPlasticisingTileConfigurationGet$Json$Response(params).pipe(
      map((r: StrictHttpResponse<PlasticisingTileConfigurationDto>) => r.body as PlasticisingTileConfigurationDto)
    );
  }

  /**
   * Path part for operation apiPlasticisingTileConfigurationPost
   */
  static readonly ApiPlasticisingTileConfigurationPostPath = '/api/plasticising-tile-configuration';

  /**
   * Fetches plasticising tile data based on configuration.
   *
   * Sample request:
   *             
   *     POST /plasticising-tile-configuration/
   *     {
   *         "dateTimeRangeFilter": {
   *             "dateTimeFrom": "2018-07-09T14:20:00.000Z",
   *             "dateTimeTo": "2018-07-09T14:40:00.000Z"
   *         },
   *         "selectedColumnKeys": [
   *             "cx300_Plasticising_Linearity", 
   *             "px050_Plasticising_Linearity", 
   *             "px120_Plasticising_Linearity", 
   *             "px160_Plasticising_Linearity", 
   *             "px200_Plasticising_Linearity", 
   *             "px080_Plasticising_Linearity"
   *         ],
   *         "selectedAggregations": [
   *             "average", 
   *             "minimum", 
   *             "maximum"
   *         ]
   *     }
   *
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiPlasticisingTileConfigurationPost$Plain()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiPlasticisingTileConfigurationPost$Plain$Response(params?: {
    context?: HttpContext
    body?: PlasticisingTileConfigureRequestDto
  }
): Observable<StrictHttpResponse<PlasticisingTileDto>> {

    const rb = new RequestBuilder(this.rootUrl, PlasticisingTileConfigurationService.ApiPlasticisingTileConfigurationPostPath, 'post');
    if (params) {
      rb.body(params.body, 'application/*+json');
    }

    return this.http.request(rb.build({
      responseType: 'text',
      accept: 'text/plain',
      context: params?.context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return r as StrictHttpResponse<PlasticisingTileDto>;
      })
    );
  }

  /**
   * Fetches plasticising tile data based on configuration.
   *
   * Sample request:
   *             
   *     POST /plasticising-tile-configuration/
   *     {
   *         "dateTimeRangeFilter": {
   *             "dateTimeFrom": "2018-07-09T14:20:00.000Z",
   *             "dateTimeTo": "2018-07-09T14:40:00.000Z"
   *         },
   *         "selectedColumnKeys": [
   *             "cx300_Plasticising_Linearity", 
   *             "px050_Plasticising_Linearity", 
   *             "px120_Plasticising_Linearity", 
   *             "px160_Plasticising_Linearity", 
   *             "px200_Plasticising_Linearity", 
   *             "px080_Plasticising_Linearity"
   *         ],
   *         "selectedAggregations": [
   *             "average", 
   *             "minimum", 
   *             "maximum"
   *         ]
   *     }
   *
   * This method provides access to only to the response body.
   * To access the full response (for headers, for example), `apiPlasticisingTileConfigurationPost$Plain$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiPlasticisingTileConfigurationPost$Plain(params?: {
    context?: HttpContext
    body?: PlasticisingTileConfigureRequestDto
  }
): Observable<PlasticisingTileDto> {

    return this.apiPlasticisingTileConfigurationPost$Plain$Response(params).pipe(
      map((r: StrictHttpResponse<PlasticisingTileDto>) => r.body as PlasticisingTileDto)
    );
  }

  /**
   * Fetches plasticising tile data based on configuration.
   *
   * Sample request:
   *             
   *     POST /plasticising-tile-configuration/
   *     {
   *         "dateTimeRangeFilter": {
   *             "dateTimeFrom": "2018-07-09T14:20:00.000Z",
   *             "dateTimeTo": "2018-07-09T14:40:00.000Z"
   *         },
   *         "selectedColumnKeys": [
   *             "cx300_Plasticising_Linearity", 
   *             "px050_Plasticising_Linearity", 
   *             "px120_Plasticising_Linearity", 
   *             "px160_Plasticising_Linearity", 
   *             "px200_Plasticising_Linearity", 
   *             "px080_Plasticising_Linearity"
   *         ],
   *         "selectedAggregations": [
   *             "average", 
   *             "minimum", 
   *             "maximum"
   *         ]
   *     }
   *
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiPlasticisingTileConfigurationPost$Json()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiPlasticisingTileConfigurationPost$Json$Response(params?: {
    context?: HttpContext
    body?: PlasticisingTileConfigureRequestDto
  }
): Observable<StrictHttpResponse<PlasticisingTileDto>> {

    const rb = new RequestBuilder(this.rootUrl, PlasticisingTileConfigurationService.ApiPlasticisingTileConfigurationPostPath, 'post');
    if (params) {
      rb.body(params.body, 'application/*+json');
    }

    return this.http.request(rb.build({
      responseType: 'json',
      accept: 'text/json',
      context: params?.context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return r as StrictHttpResponse<PlasticisingTileDto>;
      })
    );
  }

  /**
   * Fetches plasticising tile data based on configuration.
   *
   * Sample request:
   *             
   *     POST /plasticising-tile-configuration/
   *     {
   *         "dateTimeRangeFilter": {
   *             "dateTimeFrom": "2018-07-09T14:20:00.000Z",
   *             "dateTimeTo": "2018-07-09T14:40:00.000Z"
   *         },
   *         "selectedColumnKeys": [
   *             "cx300_Plasticising_Linearity", 
   *             "px050_Plasticising_Linearity", 
   *             "px120_Plasticising_Linearity", 
   *             "px160_Plasticising_Linearity", 
   *             "px200_Plasticising_Linearity", 
   *             "px080_Plasticising_Linearity"
   *         ],
   *         "selectedAggregations": [
   *             "average", 
   *             "minimum", 
   *             "maximum"
   *         ]
   *     }
   *
   * This method provides access to only to the response body.
   * To access the full response (for headers, for example), `apiPlasticisingTileConfigurationPost$Json$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiPlasticisingTileConfigurationPost$Json(params?: {
    context?: HttpContext
    body?: PlasticisingTileConfigureRequestDto
  }
): Observable<PlasticisingTileDto> {

    return this.apiPlasticisingTileConfigurationPost$Json$Response(params).pipe(
      map((r: StrictHttpResponse<PlasticisingTileDto>) => r.body as PlasticisingTileDto)
    );
  }

  /**
   * Path part for operation apiPlasticisingTileConfigurationIdGet
   */
  static readonly ApiPlasticisingTileConfigurationIdGetPath = '/api/plasticising-tile-configuration/{id}';

  /**
   * Retrieves plasticising tile configuration with the given id.
   *
   * Sample request:
   *             
   *     GET /plasticising-tile-configuration/5993049c-7cb1-47fe-87f0-35f06d5982f9
   *
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiPlasticisingTileConfigurationIdGet$Plain()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiPlasticisingTileConfigurationIdGet$Plain$Response(params: {

    /**
     * The id of the plasticising tile configuration.
     */
    id: string;
    context?: HttpContext
  }
): Observable<StrictHttpResponse<PlasticisingTileConfigurationDto>> {

    const rb = new RequestBuilder(this.rootUrl, PlasticisingTileConfigurationService.ApiPlasticisingTileConfigurationIdGetPath, 'get');
    if (params) {
      rb.path('id', params.id, {});
    }

    return this.http.request(rb.build({
      responseType: 'text',
      accept: 'text/plain',
      context: params?.context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return r as StrictHttpResponse<PlasticisingTileConfigurationDto>;
      })
    );
  }

  /**
   * Retrieves plasticising tile configuration with the given id.
   *
   * Sample request:
   *             
   *     GET /plasticising-tile-configuration/5993049c-7cb1-47fe-87f0-35f06d5982f9
   *
   * This method provides access to only to the response body.
   * To access the full response (for headers, for example), `apiPlasticisingTileConfigurationIdGet$Plain$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiPlasticisingTileConfigurationIdGet$Plain(params: {

    /**
     * The id of the plasticising tile configuration.
     */
    id: string;
    context?: HttpContext
  }
): Observable<PlasticisingTileConfigurationDto> {

    return this.apiPlasticisingTileConfigurationIdGet$Plain$Response(params).pipe(
      map((r: StrictHttpResponse<PlasticisingTileConfigurationDto>) => r.body as PlasticisingTileConfigurationDto)
    );
  }

  /**
   * Retrieves plasticising tile configuration with the given id.
   *
   * Sample request:
   *             
   *     GET /plasticising-tile-configuration/5993049c-7cb1-47fe-87f0-35f06d5982f9
   *
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiPlasticisingTileConfigurationIdGet$Json()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiPlasticisingTileConfigurationIdGet$Json$Response(params: {

    /**
     * The id of the plasticising tile configuration.
     */
    id: string;
    context?: HttpContext
  }
): Observable<StrictHttpResponse<PlasticisingTileConfigurationDto>> {

    const rb = new RequestBuilder(this.rootUrl, PlasticisingTileConfigurationService.ApiPlasticisingTileConfigurationIdGetPath, 'get');
    if (params) {
      rb.path('id', params.id, {});
    }

    return this.http.request(rb.build({
      responseType: 'json',
      accept: 'text/json',
      context: params?.context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return r as StrictHttpResponse<PlasticisingTileConfigurationDto>;
      })
    );
  }

  /**
   * Retrieves plasticising tile configuration with the given id.
   *
   * Sample request:
   *             
   *     GET /plasticising-tile-configuration/5993049c-7cb1-47fe-87f0-35f06d5982f9
   *
   * This method provides access to only to the response body.
   * To access the full response (for headers, for example), `apiPlasticisingTileConfigurationIdGet$Json$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiPlasticisingTileConfigurationIdGet$Json(params: {

    /**
     * The id of the plasticising tile configuration.
     */
    id: string;
    context?: HttpContext
  }
): Observable<PlasticisingTileConfigurationDto> {

    return this.apiPlasticisingTileConfigurationIdGet$Json$Response(params).pipe(
      map((r: StrictHttpResponse<PlasticisingTileConfigurationDto>) => r.body as PlasticisingTileConfigurationDto)
    );
  }

}
