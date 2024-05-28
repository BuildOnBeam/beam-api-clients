import * as fs from 'fs';

/**
 * One of our responses contain a property with the name 'symbol'. Our generator creates a very usable output
 * but it's not smart enough to recognize that 'symbol' is a reserved keyword and generates an enum based on the property.
 *
 * Therefore, we automatically replace 'symbol' for 'currencySymbol' and call it a day.
 */

const file = './src/generated/models/GetAssetResponse.ts';

fs.readFile(file, 'utf8', (err, data) => {
  if (err) return console.error(err);

  const formatted = data.replace(/symbol/g, 'currencySymbol');

  fs.writeFile(file, formatted, 'utf8', (err) => {
    if (err) return console.error(err);
  });
});
