import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from "@angular/platform-browser/animations";
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { DropdownModule } from 'primeng/dropdown';
import { CalendarModule } from 'primeng/calendar';
import { AccordionModule } from 'primeng/accordion'; 

import { AppRoutingModule } from './app-routing.module';
import { FileService } from './services/file.service';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { HomeComponent } from './home/home.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { HeaderComponent } from './common/components/header/header.component';
import { LandingComponent } from './landing/landing.component';
import { SidebarComponent } from './common/components/sidebar/sidebar.component';
import { FooterComponent } from './common/components/footer/footer.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    HomeComponent,
    PageNotFoundComponent,
    HeaderComponent,
    LandingComponent,
    SidebarComponent,
    FooterComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    DropdownModule,
    CalendarModule,
    AccordionModule,
/*    ToastModule,
    SharedModule,
    LoadingImageModule,
    InputBehaviorModule*/
  ],
  providers: [FileService],
  bootstrap: [AppComponent]
})
export class AppModule { }
