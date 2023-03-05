import { Component } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-dish',
  templateUrl: './dish.component.html',
  styleUrls: ['./dish.component.css'],
})
export class DishComponent {
  constructor(private http: HttpClient) {}

  addDishForm = new FormGroup({
    dishPrice: new FormControl(0),
    dishName: new FormControl(''),
    dishPicture: new FormControl(''),
  });

  addDishToDataBase() {
    this.http
      .post('https://localhost:7181/api/Dishes', this.addDishForm.value)
      .subscribe();
    alert('Dish added to database');
  }
}
