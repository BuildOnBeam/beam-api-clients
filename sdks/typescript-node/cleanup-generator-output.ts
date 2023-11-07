import { replaceStringInFilesSync } from 'tiny-replace-files';

/**
 * One of our responses contain a property with the name 'symbol'. Our generator creates a very usable output
 * but it's not smart enough to recognize that 'symbol' is a reserved keyword and generates an enum based on the property.
 *
 * Therefore, we automatically replace 'symbol' for 'currencySymbol' and call it a day.
 */

const options = {
  files: 'src/generated/models/GetAssetResponse.ts',
  from: 'symbol',
  to: 'currencySymbol',
};

replaceStringInFilesSync(options);
