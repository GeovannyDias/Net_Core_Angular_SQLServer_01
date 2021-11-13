import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { Subscription } from 'rxjs';
import { CreditCardI } from '../../models/card.interface';
import { CreditCardService } from '../../services/credit-card.service';

@Component({
  selector: 'app-list-credit-card',
  templateUrl: './list-credit-card.component.html',
  styleUrls: ['./list-credit-card.component.scss']
})
export class ListCreditCardComponent implements OnInit {
  listCards: CreditCardI[];
  listSubs: Subscription;
  eventSubs: Subscription;
  @Output() deleteCard = new EventEmitter<number>(); // Delete Card (id_card) → TEST No utilizado

  constructor(
    private creditCardService: CreditCardService,
    private toastr: ToastrService,
  ) { }

  ngOnInit(): void {
    this.getCreditCards();
    this.listenPostEvent();
  }

  getCreditCards() {
    if (this.listSubs) this.listSubs.unsubscribe();
    this.listSubs = this.creditCardService.getCreditCards().subscribe(data => {
      this.listCards = data;
      console.log('data:', data);
    });
  }

  listenPostEvent() {
    if (this.eventSubs) this.eventSubs.unsubscribe();
    this.eventSubs = this.creditCardService.cardEventListener.subscribe(data => {
      console.log('cardEventListener:', data);
      this.getCreditCards();
    });
  }

  updateCreditCard(card: CreditCardI) {
    this.creditCardService.updateEventListener.emit(card);
  }

  deleteCreditCard(id: number) {
    this.creditCardService.deleteCreditCards(id).subscribe(res => {
      console.log('DELETE:', res);
      this.getCreditCards();
      this.toastr.success('Credit card deleted.', 'Excellent!', { closeButton: true });
    });

    // Test de comunicacion (Hijo a Padre (Home))
    this.deleteCard.emit(id);
  }

}
