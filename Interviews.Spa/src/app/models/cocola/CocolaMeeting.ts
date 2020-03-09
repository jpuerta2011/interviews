export class CocolaMeeting{
    id: number;
    description: String;
    location: String;
    target: String;
    meetingDate: Date;
    createdDate: Date;
    meetingTime: String;
    meetingRealDate?: Date;
    finalComments?: String;


    /**
     *
     */
    constructor() {

    }
}