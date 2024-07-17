import { ApplicationConfig, NgModule, provideZoneChangeDetection } from '@angular/core';
import { provideRouter } from '@angular/router';

import { routes } from './app.routes';
import { provideClientHydration } from '@angular/platform-browser';
import { provideHttpClient, withFetch } from '@angular/common/http'

export const appConfig: ApplicationConfig = {
  providers: [provideZoneChangeDetection({ eventCoalescing: true}), provideRouter(routes), provideClientHydration(), provideHttpClient(withFetch())]
};

@NgModule({
  imports:[],
  declarations:[],
  exports:[],
  bootstrap:[]
})
export class appModule{}