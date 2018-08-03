import { Photo } from './photo';

export interface User {
    // same as the [UserForListDto] in the API
    id: number;
    username: string;
    knownAs: string;
    age: number;
    gender: string;
    created: Date;
    lastActive: Date;
    photoUrl: string;
    city: string;
    country: string;

    // Additional - same as the [UserForDetailedDto] in the API
    interests?: string;
    introduction?: string;
    lookingFor?: string;
    photos?: Photo[];
}
