import { defineConfig } from 'tsup';

export default defineConfig({
  entry: ['src/index.ts'],
  dts: 'src/index.ts',
  format: ['cjs', 'esm', 'iife'],
  target: 'esnext',
  sourcemap: false,
  splitting: true,
  treeshake: true,
  clean: true
});
