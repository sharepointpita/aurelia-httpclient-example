import {autoinject} from 'aurelia-framework';
import {HttpClient} from 'aurelia-fetch-client';
import 'fetch';

@autoinject
export class Dashboard {
    bla: Ticket;
  firstName = 'Joep';
  lastName = 'Roberts';
  previousValue = this.fullName;
  customer = 'Het Rughuis';
  heading = `Klant: ${this.customer}`;
  tickets: Ticket[] = [];

  //tickets = Ticket[] = [];

  //Getters can't be directly observed, so they must be dirty checked.
  //However, if you tell Aurelia the dependencies, it no longer needs to dirty check the property.
  //To optimize by declaring the properties that this getter is computed from, uncomment the line below
  //as well as the corresponding import above.
  //@computedFrom('firstName', 'lastName')
  get fullName() {
    return `${this.firstName} ${this.lastName}`;
  }

  constructor(private http: HttpClient) {
      http.configure(config => {
          config
              .useStandardConfiguration()
              .withBaseUrl('http://localhost:5000/api');
      });
  }

  activate() {
      return this.http.fetch("/ticket")
          .then(response => response.json())
          .then(data => {
              this.tickets = data;
              console.log(this.tickets);
          });
  }

  highlightRow(ticket : Ticket) {
      this.tickets.forEach(x => x.isSelected = false); 
      this.tickets.filter(x => x.id === ticket.id)[0].isSelected = true;
      console.log('ticketId: ', ticket.id, ' isSelected: ', ticket.isSelected);
  }

  //submit() {
  //  this.previousValue = this.fullName;
  //  alert(`Welcome, ${this.fullName}!`);
  //}

  //canDeactivate() {
  //  if (this.fullName !== this.previousValue) {
  //    return confirm('Are you sure you want to leave?');
  //  }
  //}
}

export class UpperValueConverter {
  toView(value) {
    return value && value.toUpperCase();
  }
}

export class Ticket {

    id: number;
    description: string;
    status: string;
    owner: string;
    isSelected: boolean = false;

}
