import { ApplicationConfig, NgModule, provideZoneChangeDetection } from '@angular/core';
import { provideRouter } from '@angular/router';

import { routes } from './app.routes';
import { BrowserModule, provideClientHydration } from '@angular/platform-browser';
import { provideHttpClient, withFetch } from '@angular/common/http'
import { ProductComponent } from './product/product.component';
import { FormsModule } from '@angular/forms'; 
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { PrimengModule } from './Common/primeng.module';


export const appConfig: ApplicationConfig = {
  providers: [provideZoneChangeDetection({ eventCoalescing: true}), provideRouter(routes), provideClientHydration(), provideHttpClient(withFetch())]
};

@NgModule({
  declarations:[ProductComponent],
  imports:[
    BrowserModule,
    FormsModule,
    BrowserAnimationsModule,
    PrimengModule
  ],
  exports:[],
  bootstrap:[]
})
export class appModule{}