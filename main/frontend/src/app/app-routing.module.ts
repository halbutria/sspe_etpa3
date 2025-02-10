import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './components/login/login.component';
import { RegisterComponent } from './components/register/register.component';
import { CvComponent } from './components/cv/cv.component';
import { AdministrativoComponent } from './administrativo/administrativo.component';

const routes: Routes = [
  { path: '', redirectTo: 'login', pathMatch: 'full' },
  { path: 'login', component: LoginComponent },
  { path: 'register', component: RegisterComponent },
  { path: 'cv', component: CvComponent },
  {
    path: 'empresas',
    loadChildren: () => import('./empresas/empresas.module').then(m => m.EmpresasModule)
  },
  {
    path: 'administrativo', component: AdministrativoComponent
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
