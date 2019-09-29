import { Component, OnInit } from '@angular/core';
import { SignalRService } from '../services/signal-r.service';
export interface Section {
  name: string;
  updated: Date;
}
@Component({
  selector: 'app-actors-view',
  templateUrl: './actors-view.component.html',
  styleUrls: ['./actors-view.component.scss']
})
export class ActorsViewComponent {
  folders: Section[] = [
    {
      name: 'Photos',
      updated: new Date('1/1/16'),
    },
    {
      name: 'Recipes',
      updated: new Date('1/17/16'),
    },
    {
      name: 'Work',
      updated: new Date('1/28/16'),
    }
  ];

  notes: Section[] = [
    {
      name: 'Vacation Itinerary',
      updated: new Date('2/20/16'),
    },
    {
      name: 'Kitchen Remodel',
      updated: new Date('1/18/16'),
    }
  ];
  constructor() { }

}
