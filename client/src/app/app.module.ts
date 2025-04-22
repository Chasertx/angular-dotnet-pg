import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { PortfolioComponent } from './services/portfolio.component';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module'; // 👈 Add this

@NgModule({
  declarations: [AppComponent, PortfolioComponent],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule, // 👈 Add this
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
