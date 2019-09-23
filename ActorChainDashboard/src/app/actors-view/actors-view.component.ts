import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-actors-view',
  templateUrl: './actors-view.component.html',
  styleUrls: ['./actors-view.component.scss']
})
export class ActorsViewComponent implements OnInit {
 data = {
  json: [
    {
      'guid': 'bc4c7a02-5379-4046-92be-12c67af4295a',
      'displayName': 'Elentrix',
      'children': [
        '85d412c2-ebc1-4d56-96c9-7da433ac9bb2',
        '28aac445-83b1-464d-9695-a4157dab6eac'
      ]
    }
  ],
  config: {
    nodeWidth: 200,
    nodeHeight: 100
  }
};
  constructor() { }

  ngOnInit() {
  }

}
