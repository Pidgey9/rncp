import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MenuComponent } from './menu/menu.component';
import { ExoComponent } from './exo/exo.component';
import { CoursComponent } from './cours/cours.component';
import { DoubleComponent } from './double/double.component';
import { AvancementComponent } from './avancement/avancement.component';
import { ConnexionComponent } from './connexion/connexion.component';
import { InscriptionComponent } from './inscription/inscription.component';
import { InfoComponent } from './info/info.component';
import { UnityComponent } from './unity/unity.component';

const routes: Routes = [
  {path: 'menu', component: MenuComponent},
  {path: 'exo', component: ExoComponent},
  {path: 'cours', component: CoursComponent},
  {path: 'double/:id', component: DoubleComponent},
  {path: 'avancement', component: AvancementComponent},
  {path: 'connexion', component: ConnexionComponent},
  {path: 'inscription', component: InscriptionComponent},
  {path: 'info', component: InfoComponent},
  {path: 'unity', component: UnityComponent},

  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
