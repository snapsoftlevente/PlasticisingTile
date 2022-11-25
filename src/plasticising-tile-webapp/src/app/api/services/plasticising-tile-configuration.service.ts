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
   * Path part for operation getConfiguration
   */
  static readonly GetConfigurationPath = '/api/plasticising-tile-configuration';

  /**
   * Retrieves plasticising tile default configuration.
   *
   * Sample request:
   *             
   *     GET /plasticising-tile-configuration
   *
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `getConfiguration$Plain()` instead.
   *
   * This method doesn't expect any request body.
   */
  getConfiguration$Plain$Response(params?: {
    context?: HttpContext
  }
): Observable<StrictHttpResponse<PlasticisingTileConfigurationDto>> {

    const rb = new RequestBuilder(this.rootUrl, PlasticisingTileConfigurationService.GetConfigurationPath, 'get');
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
   * To access the full response (for headers, for example), `getConfiguration$Plain$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  getConfiguration$Plain(params?: {
    context?: HttpContext
  }
): Observable<PlasticisingTileConfigurationDto> {

    return this.getConfiguration$Plain$Response(params).pipe(
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
   * To access only the response body, use `getConfiguration$Json()` instead.
   *
   * This method doesn't expect any request body.
   */
  getConfiguration$Json$Response(params?: {
    context?: HttpContext
  }
): Observable<StrictHttpResponse<PlasticisingTileConfigurationDto>> {

    const rb = new RequestBuilder(this.rootUrl, PlasticisingTileConfigurationService.GetConfigurationPath, 'get');
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
   * To access the full response (for headers, for example), `getConfiguration$Json$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  getConfiguration$Json(params?: {
    context?: HttpContext
  }
): Observable<PlasticisingTileConfigurationDto> {

    return this.getConfiguration$Json$Response(params).pipe(
      map((r: StrictHttpResponse<PlasticisingTileConfigurationDto>) => r.body as PlasticisingTileConfigurationDto)
    );
  }

  /**
   * Path part for operation getTileByConfiguration
   */
  static readonly GetTileByConfigurationPath = '/api/plasticising-tile-configuration';

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
   * To access only the response body, use `getTileByConfiguration$Plain()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  getTileByConfiguration$Plain$Response(params?: {
    context?: HttpContext
    body?: PlasticisingTileConfigureRequestDto
  }
): Observable<StrictHttpResponse<PlasticisingTileDto>> {

    const rb = new RequestBuilder(this.rootUrl, PlasticisingTileConfigurationService.GetTileByConfigurationPath, 'post');
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
   * To access the full response (for headers, for example), `getTileByConfiguration$Plain$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  getTileByConfiguration$Plain(params?: {
    context?: HttpContext
    body?: PlasticisingTileConfigureRequestDto
  }
): Observable<PlasticisingTileDto> {

    return this.getTileByConfiguration$Plain$Response(params).pipe(
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
   * To access only the response body, use `getTileByConfiguration$Json()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  getTileByConfiguration$Json$Response(params?: {
    context?: HttpContext
    body?: PlasticisingTileConfigureRequestDto
  }
): Observable<StrictHttpResponse<PlasticisingTileDto>> {

    const rb = new RequestBuilder(this.rootUrl, PlasticisingTileConfigurationService.GetTileByConfigurationPath, 'post');
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
   * To access the full response (for headers, for example), `getTileByConfiguration$Json$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  getTileByConfiguration$Json(params?: {
    context?: HttpContext
    body?: PlasticisingTileConfigureRequestDto
  }
): Observable<PlasticisingTileDto> {

    return this.getTileByConfiguration$Json$Response(params).pipe(
      map((r: StrictHttpResponse<PlasticisingTileDto>) => r.body as PlasticisingTileDto)
    );
  }

  /**
   * Path part for operation getConfigurationByTileId
   */
  static readonly GetConfigurationByTileIdPath = '/api/plasticising-tile-configuration/{id}';

  /**
   * Retrieves plasticising tile configuration with the given id.
   *
   * Sample request:
   *             
   *     GET /plasticising-tile-configuration/5993049c-7cb1-47fe-87f0-35f06d5982f9
   *
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `getConfigurationByTileId$Plain()` instead.
   *
   * This method doesn't expect any request body.
   */
  getConfigurationByTileId$Plain$Response(params: {

    /**
     * The id of the plasticising tile configuration.
     */
    id: string;
    context?: HttpContext
  }
): Observable<StrictHttpResponse<PlasticisingTileConfigurationDto>> {

    const rb = new RequestBuilder(this.rootUrl, PlasticisingTileConfigurationService.GetConfigurationByTileIdPath, 'get');
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
   * To access the full response (for headers, for example), `getConfigurationByTileId$Plain$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  getConfigurationByTileId$Plain(params: {

    /**
     * The id of the plasticising tile configuration.
     */
    id: string;
    context?: HttpContext
  }
): Observable<PlasticisingTileConfigurationDto> {

    return this.getConfigurationByTileId$Plain$Response(params).pipe(
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
   * To access only the response body, use `getConfigurationByTileId$Json()` instead.
   *
   * This method doesn't expect any request body.
   */
  getConfigurationByTileId$Json$Response(params: {

    /**
     * The id of the plasticising tile configuration.
     */
    id: string;
    context?: HttpContext
  }
): Observable<StrictHttpResponse<PlasticisingTileConfigurationDto>> {

    const rb = new RequestBuilder(this.rootUrl, PlasticisingTileConfigurationService.GetConfigurationByTileIdPath, 'get');
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
   * To access the full response (for headers, for example), `getConfigurationByTileId$Json$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  getConfigurationByTileId$Json(params: {

    /**
     * The id of the plasticising tile configuration.
     */
    id: string;
    context?: HttpContext
  }
): Observable<PlasticisingTileConfigurationDto> {

    return this.getConfigurationByTileId$Json$Response(params).pipe(
      map((r: StrictHttpResponse<PlasticisingTileConfigurationDto>) => r.body as PlasticisingTileConfigurationDto)
    );
  }

}
