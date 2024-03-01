import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-double',
  templateUrl: './double.component.html',
  styleUrls: ['./double.component.css']
})
export class DoubleComponent {
  id:number
  constructor(private route: ActivatedRoute, private router:Router){}

  ngOnInit(): void {


    this.route.params.subscribe(params => {

      this.id = params['id'];

    });
    this.router.navigate([this.router.url])
  }
  precedent(){
    this.router.navigateByUrl('/double/'+ --this.id).then(() => {
      // Once navigation is done, refresh the page
      window.location.reload();
    })
  }
  suivant(){
    this.router.navigateByUrl('/double/'+ ++this.id).then(() => {
      // Once navigation is done, refresh the page
      window.location.reload();
    })
  }
}