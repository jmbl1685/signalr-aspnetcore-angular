import { TestBed, async, inject } from '@angular/core/testing';
import { HttpClientTestingModule } from '@angular/common/http/testing';

import { AppComponent } from './app.component';
import { CardComponent } from './components/card/card.component';

import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { BrowserModule } from '@angular/platform-browser';

import { AppService } from './app.service';

describe('AppComponent Test', () => {

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [
        AppComponent,
        CardComponent,
      ],
      imports: [
        BrowserModule,
        HttpClientTestingModule,
        FontAwesomeModule
      ],
      providers: [AppService],
    }).compileComponents();

  }));

  it('should create the app', async(() => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.debugElement.componentInstance;
    expect(app.title).toContain('App Component')
    expect(app.FoodList).toBeTruthy()
  }));

});
