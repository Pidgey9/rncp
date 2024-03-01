import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Quiz } from '../quiz';

@Component({
  selector: 'app-exo',
  templateUrl: './exo.component.html',
  styleUrls: ['./exo.component.css']
})
export class ExoComponent {
  id:number
  q:Quiz
  reponse:string
  message:string
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
  valider(){
    if(this.reponse == this.q.Reponse){
      this.message = "Bonne réponse"
    }
    else{
      this.message = "Mauvaise réponse."
    }

  }

}
