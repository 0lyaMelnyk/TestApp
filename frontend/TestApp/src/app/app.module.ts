import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { MainPageModule } from './main-page/main-page.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {HttpService} from '../app/core/http.service';
@NgModule({
  declarations: [
    AppComponent, HttpService
  ],
  imports: [
    BrowserModule, MainPageModule, BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
