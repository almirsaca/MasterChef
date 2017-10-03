import { Component, OnInit  } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
    selector: 'app-autor',
    templateUrl: './autor.component.html',
})
export class AutorComponent implements OnInit {
   
   
    autores: string[];
   
    constructor(private http: HttpClient) { }

    ngOnInit() {

        this.http.get('/api/items').subscribe(data => {
            this.autores = data['results'];
        });

    }
}
