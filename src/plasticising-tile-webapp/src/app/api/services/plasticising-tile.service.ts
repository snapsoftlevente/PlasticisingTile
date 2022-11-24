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

import { PlasticisingTileDto } from '../models/plasticising-tile-dto';
import { PlasticisingTileSaveRequestDto } from '../models/plasticising-tile-save-request-dto';
import { PlasticisingTileSaveResponseDto } from '../models/plasticising-tile-save-response-dto';

@Injectable({
  providedIn: 'root',
})
export class PlasticisingTileService extends BaseService {
  constructor(
    config: ApiConfiguration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * Path part for operation apiPlasticisingTileIdGet
   */
  static readonly ApiPlasticisingTileIdGetPath = '/api/plasticising-tile/{id}';

  /**
   * Retrieves plasticising tile with the given id.
   *
   * Sample request:
   *             
   *     GET /plasticising-tile/c575d3a9-05f3-4d4c-a4c7-6e820c29312c
   *
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiPlasticisingTileIdGet$Plain()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiPlasticisingTileIdGet$Plain$Response(params: {

    /**
     * The id of the plasticising tile.
     */
    id: string;
    context?: HttpContext
  }
): Observable<StrictHttpResponse<PlasticisingTileDto>> {

    const rb = new RequestBuilder(this.rootUrl, PlasticisingTileService.ApiPlasticisingTileIdGetPath, 'get');
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
        return r as StrictHttpResponse<PlasticisingTileDto>;
      })
    );
  }

  /**
   * Retrieves plasticising tile with the given id.
   *
   * Sample request:
   *             
   *     GET /plasticising-tile/c575d3a9-05f3-4d4c-a4c7-6e820c29312c
   *
   * This method provides access to only to the response body.
   * To access the full response (for headers, for example), `apiPlasticisingTileIdGet$Plain$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiPlasticisingTileIdGet$Plain(params: {

    /**
     * The id of the plasticising tile.
     */
    id: string;
    context?: HttpContext
  }
): Observable<PlasticisingTileDto> {

    return this.apiPlasticisingTileIdGet$Plain$Response(params).pipe(
      map((r: StrictHttpResponse<PlasticisingTileDto>) => r.body as PlasticisingTileDto)
    );
  }

  /**
   * Retrieves plasticising tile with the given id.
   *
   * Sample request:
   *             
   *     GET /plasticising-tile/c575d3a9-05f3-4d4c-a4c7-6e820c29312c
   *
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiPlasticisingTileIdGet$Json()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiPlasticisingTileIdGet$Json$Response(params: {

    /**
     * The id of the plasticising tile.
     */
    id: string;
    context?: HttpContext
  }
): Observable<StrictHttpResponse<PlasticisingTileDto>> {

    const rb = new RequestBuilder(this.rootUrl, PlasticisingTileService.ApiPlasticisingTileIdGetPath, 'get');
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
        return r as StrictHttpResponse<PlasticisingTileDto>;
      })
    );
  }

  /**
   * Retrieves plasticising tile with the given id.
   *
   * Sample request:
   *             
   *     GET /plasticising-tile/c575d3a9-05f3-4d4c-a4c7-6e820c29312c
   *
   * This method provides access to only to the response body.
   * To access the full response (for headers, for example), `apiPlasticisingTileIdGet$Json$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiPlasticisingTileIdGet$Json(params: {

    /**
     * The id of the plasticising tile.
     */
    id: string;
    context?: HttpContext
  }
): Observable<PlasticisingTileDto> {

    return this.apiPlasticisingTileIdGet$Json$Response(params).pipe(
      map((r: StrictHttpResponse<PlasticisingTileDto>) => r.body as PlasticisingTileDto)
    );
  }

  /**
   * Path part for operation apiPlasticisingTileIdPut
   */
  static readonly ApiPlasticisingTileIdPutPath = '/api/plasticising-tile/{id}';

  /**
   * Saves configuration for plasticising tile.
   *
   * Sample request:
   *             
   *     PUT /plasticising-tile/c575d3a9-05f3-4d4c-a4c7-6e820c29312c
   *     {
   *        "": "",
   *        "": ""
   *     }
   *
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiPlasticisingTileIdPut$Plain()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiPlasticisingTileIdPut$Plain$Response(params: {
    id: string;
    context?: HttpContext
    body?: PlasticisingTileSaveRequestDto
  }
): Observable<StrictHttpResponse<PlasticisingTileSaveResponseDto>> {

    const rb = new RequestBuilder(this.rootUrl, PlasticisingTileService.ApiPlasticisingTileIdPutPath, 'put');
    if (params) {
      rb.path('id', params.id, {});
      rb.body(params.body, 'application/*+json');
    }

    return this.http.request(rb.build({
      responseType: 'text',
      accept: 'text/plain',
      context: params?.context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return r as StrictHttpResponse<PlasticisingTileSaveResponseDto>;
      })
    );
  }

  /**
   * Saves configuration for plasticising tile.
   *
   * Sample request:
   *             
   *     PUT /plasticising-tile/c575d3a9-05f3-4d4c-a4c7-6e820c29312c
   *     {
   *        "": "",
   *        "": ""
   *     }
   *
   * This method provides access to only to the response body.
   * To access the full response (for headers, for example), `apiPlasticisingTileIdPut$Plain$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiPlasticisingTileIdPut$Plain(params: {
    id: string;
    context?: HttpContext
    body?: PlasticisingTileSaveRequestDto
  }
): Observable<PlasticisingTileSaveResponseDto> {

    return this.apiPlasticisingTileIdPut$Plain$Response(params).pipe(
      map((r: StrictHttpResponse<PlasticisingTileSaveResponseDto>) => r.body as PlasticisingTileSaveResponseDto)
    );
  }

  /**
   * Saves configuration for plasticising tile.
   *
   * Sample request:
   *             
   *     PUT /plasticising-tile/c575d3a9-05f3-4d4c-a4c7-6e820c29312c
   *     {
   *        "": "",
   *        "": ""
   *     }
   *
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiPlasticisingTileIdPut$Json()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiPlasticisingTileIdPut$Json$Response(params: {
    id: string;
    context?: HttpContext
    body?: PlasticisingTileSaveRequestDto
  }
): Observable<StrictHttpResponse<PlasticisingTileSaveResponseDto>> {

    const rb = new RequestBuilder(this.rootUrl, PlasticisingTileService.ApiPlasticisingTileIdPutPath, 'put');
    if (params) {
      rb.path('id', params.id, {});
      rb.body(params.body, 'application/*+json');
    }

    return this.http.request(rb.build({
      responseType: 'json',
      accept: 'text/json',
      context: params?.context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return r as StrictHttpResponse<PlasticisingTileSaveResponseDto>;
      })
    );
  }

  /**
   * Saves configuration for plasticising tile.
   *
   * Sample request:
   *             
   *     PUT /plasticising-tile/c575d3a9-05f3-4d4c-a4c7-6e820c29312c
   *     {
   *        "": "",
   *        "": ""
   *     }
   *
   * This method provides access to only to the response body.
   * To access the full response (for headers, for example), `apiPlasticisingTileIdPut$Json$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiPlasticisingTileIdPut$Json(params: {
    id: string;
    context?: HttpContext
    body?: PlasticisingTileSaveRequestDto
  }
): Observable<PlasticisingTileSaveResponseDto> {

    return this.apiPlasticisingTileIdPut$Json$Response(params).pipe(
      map((r: StrictHttpResponse<PlasticisingTileSaveResponseDto>) => r.body as PlasticisingTileSaveResponseDto)
    );
  }

  /**
   * Path part for operation apiPlasticisingTilePost
   */
  static readonly ApiPlasticisingTilePostPath = '/api/plasticising-tile';

  /**
   * Adds configuration for a new plasticising tile.
   *
   * Sample request:
   *             
   *     PUT /plasticising-tile
   *     {
   *        "": "",
   *        "": ""
   *     }
   *
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiPlasticisingTilePost$Plain()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiPlasticisingTilePost$Plain$Response(params?: {
    context?: HttpContext
    body?: PlasticisingTileSaveRequestDto
  }
): Observable<StrictHttpResponse<PlasticisingTileSaveResponseDto>> {

    const rb = new RequestBuilder(this.rootUrl, PlasticisingTileService.ApiPlasticisingTilePostPath, 'post');
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
        return r as StrictHttpResponse<PlasticisingTileSaveResponseDto>;
      })
    );
  }

  /**
   * Adds configuration for a new plasticising tile.
   *
   * Sample request:
   *             
   *     PUT /plasticising-tile
   *     {
   *        "": "",
   *        "": ""
   *     }
   *
   * This method provides access to only to the response body.
   * To access the full response (for headers, for example), `apiPlasticisingTilePost$Plain$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiPlasticisingTilePost$Plain(params?: {
    context?: HttpContext
    body?: PlasticisingTileSaveRequestDto
  }
): Observable<PlasticisingTileSaveResponseDto> {

    return this.apiPlasticisingTilePost$Plain$Response(params).pipe(
      map((r: StrictHttpResponse<PlasticisingTileSaveResponseDto>) => r.body as PlasticisingTileSaveResponseDto)
    );
  }

  /**
   * Adds configuration for a new plasticising tile.
   *
   * Sample request:
   *             
   *     PUT /plasticising-tile
   *     {
   *        "": "",
   *        "": ""
   *     }
   *
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiPlasticisingTilePost$Json()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiPlasticisingTilePost$Json$Response(params?: {
    context?: HttpContext
    body?: PlasticisingTileSaveRequestDto
  }
): Observable<StrictHttpResponse<PlasticisingTileSaveResponseDto>> {

    const rb = new RequestBuilder(this.rootUrl, PlasticisingTileService.ApiPlasticisingTilePostPath, 'post');
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
        return r as StrictHttpResponse<PlasticisingTileSaveResponseDto>;
      })
    );
  }

  /**
   * Adds configuration for a new plasticising tile.
   *
   * Sample request:
   *             
   *     PUT /plasticising-tile
   *     {
   *        "": "",
   *        "": ""
   *     }
   *
   * This method provides access to only to the response body.
   * To access the full response (for headers, for example), `apiPlasticisingTilePost$Json$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiPlasticisingTilePost$Json(params?: {
    context?: HttpContext
    body?: PlasticisingTileSaveRequestDto
  }
): Observable<PlasticisingTileSaveResponseDto> {

    return this.apiPlasticisingTilePost$Json$Response(params).pipe(
      map((r: StrictHttpResponse<PlasticisingTileSaveResponseDto>) => r.body as PlasticisingTileSaveResponseDto)
    );
  }

}
