/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { GetAllUsersResponse } from '../models/GetAllUsersResponse';
import type { GetUserResponse } from '../models/GetUserResponse';
import type { UpdateUserRequest } from '../models/UpdateUserRequest';

import type { BaseHttpRequest } from '../core/BaseHttpRequest';
import type { CancelablePromise } from '../core/CancelablePromise';

export class UsersService {
  constructor(public readonly httpRequest: BaseHttpRequest) {}

  /**
   * Returns a list of users
   * @param limit
   * @param offset
   * @returns GetAllUsersResponse
   * @throws ApiError
   */
  public getAllUsers(
    limit = 10,
    offset = 0,
  ): CancelablePromise<GetAllUsersResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/player/users',
      query: {
        limit: limit,
        offset: offset,
      },
    });
  }

  /**
   * Returns a particular user
   * @param entityId
   * @returns GetUserResponse
   * @throws ApiError
   */
  public getUser(entityId: string): CancelablePromise<GetUserResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/player/users/{entityId}',
      path: {
        entityId: entityId,
      },
    });
  }

  /**
   * Updates entityId for the user
   * @param entityId
   * @param requestBody
   * @returns GetUserResponse
   * @throws ApiError
   */
  public updateUser(
    entityId: string,
    requestBody: UpdateUserRequest,
  ): CancelablePromise<GetUserResponse> {
    return this.httpRequest.request({
      method: 'PATCH',
      url: '/v1/player/users/{entityId}',
      path: {
        entityId: entityId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }

  /**
   * Unlinks an entity ID from a user
   * @param entityId
   * @returns GetUserResponse
   * @throws ApiError
   */
  public unlinkUser(entityId: string): CancelablePromise<GetUserResponse> {
    return this.httpRequest.request({
      method: 'DELETE',
      url: '/v1/player/users/{entityId}',
      path: {
        entityId: entityId,
      },
    });
  }
}
