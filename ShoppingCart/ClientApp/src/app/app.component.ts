import { Component, OnInit } from '@angular/core';
import { Router, RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export default class AppComponent implements OnInit{
  title = 'ClientApp';

  constructor(private _router:Router){}
  ngOnInit(): void {
    this._router.navigateByUrl('/product');
  }
  
}
