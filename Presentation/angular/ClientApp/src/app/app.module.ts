import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { WorkoutDetailComponent } from './workout-detail/workout-detail.component';
import { ExcerciseListComponent } from './excercise-list/excercise-list.component';
import { WorkoutListComponent } from './workout-list/workout-list.component';
import { RegisterComponent } from './register/register.component';
import { LoginComponent } from './login/login.component';
import { AboutComponent } from './about/about.component';
import { ContactComponent } from './contact/contact.component';
import { SetComponent } from './set/set.component';
import { ExcerciseComponent } from './excercise/excercise.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    DashboardComponent,
    WorkoutDetailComponent,
    ExcerciseListComponent,
    WorkoutListComponent,
    RegisterComponent,
    LoginComponent,
    AboutComponent,
    ContactComponent,
    SetComponent,
    ExcerciseComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: DashboardComponent, pathMatch: 'full' },
      { path: 'workout-detail', component: WorkoutDetailComponent },
      { path: 'excercise-list', component: ExcerciseListComponent },
      { path: 'workout-list', component: WorkoutListComponent },
      { path: 'register', component: RegisterComponent },
      { path: 'login', component: LoginComponent },
      { path: 'about', component: AboutComponent },
      { path: 'contact', component: ContactComponent },
      { path: 'set', component: SetComponent },
      { path: 'excercise', component: ExcerciseComponent },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
