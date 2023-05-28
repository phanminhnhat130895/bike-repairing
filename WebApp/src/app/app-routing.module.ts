import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateRequestFormComponent } from './components/requests/createRequestForm/create-request-form.component';

const routes: Routes = [
  { path: '', component: CreateRequestFormComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
