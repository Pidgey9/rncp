import { Component } from '@angular/core';
import { Quiz } from '../quiz';
import { ActivatedRoute } from '@angular/router';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-cours',
  templateUrl: './cours.component.html',
  styleUrls: ['./cours.component.css']
})
export class CoursComponent {
  id:number
  q:Quiz
  constructor(private route: ActivatedRoute,private http:HttpClient){}
    
  
 ngOnInit(): void {


  //partie 1
  this.route.params.subscribe(params => {

    this.id = params['id'];
    console.log(this.id);

  });
  this.http.get<Quiz>("http://localhost:49688/api/quiz/"+this.id).subscribe(
      (response) => {
        this.q=response;
       
        console.log(response);
      }
      ,
     (err) => {
        console.log("*************KO")
        
      },

      () => {
        console.log("*********complete****")
        
      }

    );
}

}
