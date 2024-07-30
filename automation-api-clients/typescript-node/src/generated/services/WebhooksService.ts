/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { CreateWebhookForGame } from '../models/CreateWebhookForGame';
import type { GetWebhooksForGameResponse } from '../models/GetWebhooksForGameResponse';
import type { WebhookForGameResponse } from '../models/WebhookForGameResponse';

import type { BaseHttpRequest } from '../core/BaseHttpRequest';
import type { CancelablePromise } from '../core/CancelablePromise';

export class WebhooksService {
  constructor(public readonly httpRequest: BaseHttpRequest) {}

  /**
   * @deprecated
   * Get webhooks registered by your game
   * @returns GetWebhooksForGameResponse List of webhooks registered for your game
   * @throws ApiError
   */
  public getWebhooksForGame(): CancelablePromise<GetWebhooksForGameResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/webhook',
    });
  }

  /**
   * @deprecated
   * Create webhook for your game
   * @param requestBody
   * @returns WebhookForGameResponse Create webhook for your game.
   * @throws ApiError
   */
  public createWebhook(
    requestBody: CreateWebhookForGame,
  ): CancelablePromise<WebhookForGameResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/webhook',
      body: requestBody,
      mediaType: 'application/json',
    });
  }

  /**
   * @deprecated
   * Delete webhook from your game
   * @param webhookId
   * @returns void
   * @throws ApiError
   */
  public deleteWebhook(webhookId: string): CancelablePromise<void> {
    return this.httpRequest.request({
      method: 'DELETE',
      url: '/v1/webhook/{webhookId}',
      path: {
        webhookId: webhookId,
      },
    });
  }
}
