# Beam self-custodial (beta)


```typescript
import { Beam as BeamSelfCustody } from '@onbeam/self-custody'

const beam = new BeamSelfCustody('your-publishable-api-key');

const game = await beam.operations.getOperatoin(opId);
```