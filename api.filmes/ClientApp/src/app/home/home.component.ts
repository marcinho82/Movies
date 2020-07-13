import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {

  @Input() email: string;

  cadastrar() {

    console.log(this.email);

  }

}
