# Beam Player API (beta)

The Beam Player API request client is meant to be implemented in **server side environments**. It allows you to read data through our service, and generate Operations for your users.


## Beam SDK

If you're looking to implement Beam in a **client side application**, for example: a web application, please refer to the [Beam SDK for web](https://www.npmjs.com/package/@onbeam/sdk).

## Getting started

In order to get started with the Player API request client, we highly recommend you to read [our documentation](https://docs.onbeam.com/service/introduction-player-api). If you can't wait to get your hands dirty, here's an easy-going snippet that should get you going. 

```typescript
import { Beam } from '@onbeam/player-api-client'

const beam = new Beam('your-publishable-api-key');

const operation = await beam.operations.getOperation('your-operation-id');
```