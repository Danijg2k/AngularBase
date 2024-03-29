export class Product {
  id: number;
  name: string | null;
  description: string | null;
  image: string | null;
  colors: string | null;

  constructor() {
    this.id = 0;
    this.name = null;
    this.description = null;
    this.image = null;
    this.colors = null;
  }
}
