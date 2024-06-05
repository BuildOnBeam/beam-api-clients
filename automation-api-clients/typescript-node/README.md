# Beam for node
The Beam client for the node.js ecosystem provides a type-safe interface for consuming the Beam API. Please note that this client is not meant to be used in client side javascript, as following these instructions in a client-side environment would expose your API key to all users.

## Connecting with Beam
In order to get started with Beam, you will need an API key. The API key for your game will be provided by your partner at Merit Circle.

## Quick Start
By importing the class and passing your API key while creating a new class instance, you will have have access to all requests.


```typescript
import { Beam } from '@onbeam/node'

const beam = new Beam('your-api-key');

const game = await beam.games.getGame();
```