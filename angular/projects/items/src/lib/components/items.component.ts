import { Component, OnInit } from '@angular/core';
import { ItemsService } from '../services/items.service';

@Component({
  selector: 'lib-items',
  template: ` <p>items works!</p> `,
  styles: [],
})
export class ItemsComponent implements OnInit {
  constructor(private service: ItemsService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
