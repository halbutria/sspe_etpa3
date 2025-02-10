import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeEmpresasComponent } from './pages/home-empresas/home-empresas.component';
import { LayoutEmpresasComponent } from './pages/layout-empresas/layout-empresas.component';
import { ListadoVacantesComponent } from './pages/listado-vacantes/listado-vacantes.component';
import { RegistrarVacanteComponent } from './pages/registrar-vacante/registrar-vacante.component';
import { SeleccionarTipoRegistroVacanteComponent } from './pages/seleccionar-tipo-registro-vacante/seleccionar-tipo-registro-vacante.component';


const routes: Routes = [
  {
    path: '',
    component: LayoutEmpresasComponent,
    children: [
      { path: '', component: HomeEmpresasComponent },
      { path: 'registrar-vacante-tipo', component: SeleccionarTipoRegistroVacanteComponent },
      { path: 'registrar-vacante', component: RegistrarVacanteComponent },
      { path: 'registrar-vacante/:accion/:vacanteId', component: RegistrarVacanteComponent },
      { path: 'listado-vacantes', component: ListadoVacantesComponent },
      { path: 'listado-vacantes/:ACCION_VACANTE', component: ListadoVacantesComponent },
    ]
  },

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class EmpresasRoutingModule { }
