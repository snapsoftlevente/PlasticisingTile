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
   * Path part for operation getTile
   */
  static readonly GetTilePath = '/api/plasticising-tile/{id}';

  /**
   * Retrieves plasticising tile with the given id.
   *
   * Sample request:
   *             
   *     GET /plasticising-tile/c575d3a9-05f3-4d4c-a4c7-6e820c29312c
   *
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `getTile$Plain()` instead.
   *
   * This method doesn't expect any request body.
   */
  getTile$Plain$Response(params: {

    /**
     * The id of the plasticising tile.
     */
    id: string;
    context?: HttpContext
  }
): Observable<StrictHttpResponse<PlasticisingTileDto>> {

    const rb = new RequestBuilder(this.rootUrl, PlasticisingTileService.GetTilePath, 'get');
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
   * To access the full response (for headers, for example), `getTile$Plain$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  getTile$Plain(params: {

    /**
     * The id of the plasticising tile.
     */
    id: string;
    context?: HttpContext
  }
): Observable<PlasticisingTileDto> {

    return this.getTile$Plain$Response(params).pipe(
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
   * To access only the response body, use `getTile$Json()` instead.
   *
   * This method doesn't expect any request body.
   */
  getTile$Json$Response(params: {

    /**
     * The id of the plasticising tile.
     */
    id: string;
    context?: HttpContext
  }
): Observable<StrictHttpResponse<PlasticisingTileDto>> {

    const rb = new RequestBuilder(this.rootUrl, PlasticisingTileService.GetTilePath, 'get');
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
   * To access the full response (for headers, for example), `getTile$Json$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  getTile$Json(params: {

    /**
     * The id of the plasticising tile.
     */
    id: string;
    context?: HttpContext
  }
): Observable<PlasticisingTileDto> {

    return this.getTile$Json$Response(params).pipe(
      map((r: StrictHttpResponse<PlasticisingTileDto>) => r.body as PlasticisingTileDto)
    );
  }

  /**
   * Path part for operation updateTile
   */
  static readonly UpdateTilePath = '/api/plasticising-tile/{id}';

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
   * To access only the response body, use `updateTile$Plain()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  updateTile$Plain$Response(params: {
    id: string;
    context?: HttpContext
    body?: PlasticisingTileSaveRequestDto
  }
): Observable<StrictHttpResponse<PlasticisingTileSaveResponseDto>> {

    const rb = new RequestBuilder(this.rootUrl, PlasticisingTileService.UpdateTilePath, 'put');
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
   * To access the full response (for headers, for example), `updateTile$Plain$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  updateTile$Plain(params: {
    id: string;
    context?: HttpContext
    body?: PlasticisingTileSaveRequestDto
  }
): Observable<PlasticisingTileSaveResponseDto> {

    return this.updateTile$Plain$Response(params).pipe(
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
   * To access only the response body, use `updateTile$Json()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  updateTile$Json$Response(params: {
    id: string;
    context?: HttpContext
    body?: PlasticisingTileSaveRequestDto
  }
): Observable<StrictHttpResponse<PlasticisingTileSaveResponseDto>> {

    const rb = new RequestBuilder(this.rootUrl, PlasticisingTileService.UpdateTilePath, 'put');
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
   * To access the full response (for headers, for example), `updateTile$Json$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  updateTile$Json(params: {
    id: string;
    context?: HttpContext
    body?: PlasticisingTileSaveRequestDto
  }
): Observable<PlasticisingTileSaveResponseDto> {

    return this.updateTile$Json$Response(params).pipe(
      map((r: StrictHttpResponse<PlasticisingTileSaveResponseDto>) => r.body as PlasticisingTileSaveResponseDto)
    );
  }

  /**
   * Path part for operation addTile
   */
  static readonly AddTilePath = '/api/plasticising-tile';

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
   * To access only the response body, use `addTile$Plain()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  addTile$Plain$Response(params?: {
    context?: HttpContext
    body?: PlasticisingTileSaveRequestDto
  }
): Observable<StrictHttpResponse<PlasticisingTileSaveResponseDto>> {

    const rb = new RequestBuilder(this.rootUrl, PlasticisingTileService.AddTilePath, 'post');
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
   * To access the full response (for headers, for example), `addTile$Plain$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  addTile$Plain(params?: {
    context?: HttpContext
    body?: PlasticisingTileSaveRequestDto
  }
): Observable<PlasticisingTileSaveResponseDto> {

    return this.addTile$Plain$Response(params).pipe(
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
   * To access only the response body, use `addTile$Json()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  addTile$Json$Response(params?: {
    context?: HttpContext
    body?: PlasticisingTileSaveRequestDto
  }
): Observable<StrictHttpResponse<PlasticisingTileSaveResponseDto>> {

    const rb = new RequestBuilder(this.rootUrl, PlasticisingTileService.AddTilePath, 'post');
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
   * To access the full response (for headers, for example), `addTile$Json$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  addTile$Json(params?: {
    context?: HttpContext
    body?: PlasticisingTileSaveRequestDto
  }
): Observable<PlasticisingTileSaveResponseDto> {

    return this.addTile$Json$Response(params).pipe(
      map((r: StrictHttpResponse<PlasticisingTileSaveResponseDto>) => r.body as PlasticisingTileSaveResponseDto)
    );
  }

}
