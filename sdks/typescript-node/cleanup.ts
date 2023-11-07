import { replaceStringInFilesSync } from 'tiny-replace-files';

const options = {
  files: 'src/generated/models/GetAssetResponse.ts',
  from: 'symbol',
  to: 'currencySymbol',
};

replaceStringInFilesSync(options);
