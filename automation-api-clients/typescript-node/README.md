# Beam Automation API

The Beam Automation API request client is meant to be implemented in **server side environments**. It allows you to create (managed) account abstractions and manage assets for said accounts accordingly, all authorized through an API key. 

## User accounts and assets

If you're looking to implement Beam for managing **user assets**, for example: to create accounts and drop assets (NFTs) that are earned by your users, please refer to the [Beam Player API](https://docs.onbeam.com/service/introduction-player-api).

If you're looking to get started with the Beam implementation for your users in an client side environment (eg; a web application or a Unity-based game), please refer to the [Beam Player API implementation](https://docs.onbeam.com/service/implementation-player-api) documentation.


## Getting started

In order to get started with the Automation API request client, we highly recommend you to read [our documentation](https://docs.onbeam.com/service/introduction-automation-api). If you can't wait to get your hands dirty, here's an easy-going snippet that should get you going. 

```typescript
import { Beam } from '@onbeam/automation-api-client'

const beam = new Beam('your-secret-api-key');

const game = await beam.operations.getGame('your-game-id');
```