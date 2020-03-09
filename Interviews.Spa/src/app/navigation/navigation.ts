import { FuseNavigation } from '@fuse/types';

export const navigation: FuseNavigation[] = [
    {
        id       : 'applications',
        title    : 'Applications',
        translate: 'NAV.APPLICATIONS',
        type     : 'group',
        children : [
            {
                id          : 'planear',
                title       : 'PLANEAR',
                translate   : 'NAV.PLANNING.TITLE',
                type        : 'collapsable',
                icon        : 'assignment',
                children:   [
                    {
                        id          : 'copasst',
                        title       : 'copasst',
                        translate   : 'NAV.PLANNING.COPASST.TITLE',
                        type        : 'collapsable',
                        icon        : 'supervised_user_circle',
                        children    : [
                            {
                                id          : 'roles',
                                title       : 'ROLES',
                                translate   : 'NAV.PLANNING.COPASST.ROLES.TITLE',
                                type        : 'item',
                                url         : '/copasst/role'
                            },
                            {
                                id          : 'meetings',
                                title       : 'MEETINGS',
                                translate   : 'NAV.PLANNING.COPASST.MEETINGS.TITLE',
                                type        : 'item',
                                url         : '/copasst/meeting/create'
                            },
                        ]   
                    }
                ]


            },
            {
                id       : 'sample',
                title    : 'Sample',
                translate: 'NAV.SAMPLE.TITLE',
                type     : 'item',
                icon     : 'email',
                url      : '/sample',
                badge    : {
                    title    : '25',
                    translate: 'NAV.SAMPLE.BADGE',
                    bg       : '#F44336',
                    fg       : '#FFFFFF'
                }
            }
        ]
    }
];
