/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { ConvertTokenRequestInput } from '../models/ConvertTokenRequestInput';
import type { GetQuoteResponse } from '../models/GetQuoteResponse';
import type { TransactionResponse } from '../models/TransactionResponse';
import type { UnwrappingTokenInput } from '../models/UnwrappingTokenInput';
import type { WrappingTokenInput } from '../models/WrappingTokenInput';
import type { CancelablePromise } from '../core/CancelablePromise';
import type { BaseHttpRequest } from '../core/BaseHttpRequest';
export class ExchangeService {
  constructor(public readonly httpRequest: BaseHttpRequest) {}
  /**
   * Returns the maximum necessary input amount for a token trade, given a desired output amount
   * @param tokenIn
   * @param tokenOut
   * @param amountOut
   * @param chainId
   * @returns GetQuoteResponse
   * @throws ApiError
   */
  public getQuoteForInput(
    tokenIn: string,
    tokenOut: string,
    amountOut: string,
    chainId?: number,
  ): CancelablePromise<GetQuoteResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/exchange/quote/input',
      query: {
        tokenIn: tokenIn,
        tokenOut: tokenOut,
        amountOut: amountOut,
        chainId: chainId,
      },
    });
  }
  /**
   * Returns the minimum expected output amount for a token trade, given an input amount
   * @param tokenIn
   * @param tokenOut
   * @param amountIn
   * @param chainId
   * @returns GetQuoteResponse
   * @throws ApiError
   */
  public getQuoteForOutput(
    tokenIn: string,
    tokenOut: string,
    amountIn: string,
    chainId?: number,
  ): CancelablePromise<GetQuoteResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/exchange/quote/output',
      query: {
        tokenIn: tokenIn,
        tokenOut: tokenOut,
        amountIn: amountIn,
        chainId: chainId,
      },
    });
  }
  /**
   * Swap an exact amount of `tokenIn` for a minimum amount of `tokenOut`
   * @param entityId
   * @param requestBody
   * @returns TransactionResponse
   * @throws ApiError
   */
  public convertInput(
    entityId: string,
    requestBody: ConvertTokenRequestInput,
  ): CancelablePromise<TransactionResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/exchange/profiles/{entityId}/convert/input',
      path: {
        entityId: entityId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }
  /**
   * Swap a maximum amount of `tokenIn` for an exact amount of `tokenOut`
   * @param entityId
   * @param requestBody
   * @returns TransactionResponse
   * @throws ApiError
   */
  public convertToOutput(
    entityId: string,
    requestBody: ConvertTokenRequestInput,
  ): CancelablePromise<TransactionResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/exchange/profiles/{entityId}/convert/output',
      path: {
        entityId: entityId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }
  /**
   * Wrap an amount of native token to wrapped native token
   * @param entityId
   * @param requestBody
   * @returns TransactionResponse
   * @throws ApiError
   */
  public wrapNative(
    entityId: string,
    requestBody: WrappingTokenInput,
  ): CancelablePromise<TransactionResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/exchange/profiles/{entityId}/native/wrap',
      path: {
        entityId: entityId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }
  /**
   * Unwrap an amount of wrapped to native token
   * @param entityId
   * @param requestBody
   * @returns TransactionResponse
   * @throws ApiError
   */
  public unwrapNative(
    entityId: string,
    requestBody: UnwrappingTokenInput,
  ): CancelablePromise<TransactionResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/exchange/profiles/{entityId}/native/unwrap',
      path: {
        entityId: entityId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }
}
