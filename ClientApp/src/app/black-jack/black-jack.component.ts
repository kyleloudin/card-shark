import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-black-jack',
  templateUrl: './black-jack.component.html',
  styleUrls: ['./styles/cards.component.css']
})
export class BlackJackComponent {
  public cards: Card[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Card[]>(baseUrl + 'blackjack').subscribe(result => {
      this.cards = result;
    }, error => console.error(error));
  }
}

interface Card {
  suit : string;
  rank : string;
}
