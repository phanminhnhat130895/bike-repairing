import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { NgxSpinnerModule } from 'ngx-spinner';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CreateRequestFormComponent } from './components/requests/createRequestForm/create-request-form.component';
import { RequestService } from './services/request.service';
import { ConfigInterceptor } from './config/http.interceptor';

@NgModule({
  declarations: [
    AppComponent,
    CreateRequestFormComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    AppRoutingModule,
    HttpClientModule,
    NgxSpinnerModule,
    BrowserAnimationsModule
  ],
  providers: [
    { provide: HTTP_INTERCEPTORS, useClass: ConfigInterceptor, multi: true },
    RequestService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
