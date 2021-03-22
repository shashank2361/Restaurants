export interface Restaurant {
  id: number;
  name: string;
  description: string;
  address: string;
  phoneNumber: string;
  rating: number;
  tags: string[];
  photoUri: string;
  familyFriendly: boolean;
  veganFriendly: boolean;
}
