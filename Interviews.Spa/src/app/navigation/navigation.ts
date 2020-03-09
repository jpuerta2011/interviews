import { FuseNavigation } from '@fuse/types';

export const navigation: FuseNavigation[] = 
[
    {
        id       : 'applications',
        title    : 'Applications',
        translate: 'NAV.APPLICATIONS',
        type     : 'group',
        children : 
        [
            {
                id          : 'settings',
                title       : 'SETTINGS',
                translate   : 'NAV.SETTINGS.TITLE',
                type        : 'collapsable',
                icon        : 'assignment',
                children:   
                [
                    {
                        id       : 'heading',
                        title    : 'Rubros',
                        type     : 'item',
                        icon     : 'email',
                        url      : '/heading/list',
                    },
                    {
                        id          : 'roles-list',
                        title       : 'ROLES',
                        translate   : 'NAV.PLANNING.COPASST.ROLES.TITLE',
                        type        : 'item',
                        url         : '/copasst/role'
                    },
                    {
                        id          : 'roles-add',
                        title       : 'ROLES_ADD',
                        translate   : 'NAV.PLANNING.COPASST.ROLES_ADD.TITLE',
                        type        : 'item',
                        url         : '/copasst/role-create'
                    },
                    {
                        id          : 'roles',
                        title       : 'ROLES',
                        translate   : 'NAV.PLANNING.COCOLA.ROLES.TITLE',
                        type        : 'item',
                        url         : '/cocola/role'
                    },
                    {
                        id          : 'roles-add',
                        title       : 'ROLES_ADD',
                        translate   : 'NAV.PLANNING.COCOLA.ROLES_ADD.TITLE',
                        type        : 'item',
                        url         : '/cocola/role-create'
                    },
                    {
                        id          : 'types',
                        title       : 'TYPES',
                        translate   : 'NAV.PLANNING.TRAINING.TYPES.TITLE',
                        type        : 'item',
                        url         : '/training/types'
                    },
                    {
                        id          : 'type_add',
                        title       : 'TYPE_ADD',
                        translate   : 'NAV.PLANNING.TRAINING.TYPE_ADD.TITLE',
                        type        : 'item',
                        url         : '/training/type_add'
                    },
                    {
                        id          : 'document_types',
                        title       : 'TYPES',
                        translate   : 'NAV.PLANNING.DOCUMENTSTRUCTURE.TYPES.TITLE',
                        type        : 'item',
                        url         : '/documentstructure/types'
                    },
                    {
                        id          : 'document_type_add',
                        title       : 'TYPE_ADD',
                        translate   : 'NAV.PLANNING.DOCUMENTSTRUCTURE.TYPE_ADD.TITLE',
                        type        : 'item',
                        url         : '/documentstructure/type_add'
                    },
                    {
                        id       : 'position',
                        title    : 'Cargos',
                        type     : 'item',
                        icon     : 'supervised_user_circle',                    
                        url      : '/position/list',
                    },
                    {
                        id          : 'User',
                        title       : 'Usuario',                        
                        icon        : 'supervised_user_circle',
                        type        : 'item',
                        url         : '/user/show'
                    },   
                    {
                        id          : 'Employee',
                        title       : 'Empleado',         
                        icon        : 'supervised_user_circle',               
                        type        : 'item',
                        url         : '/employee/list'
                    },
                    {
                        id          : 'organization-office',
                        title       : 'organization-office',
                        translate   : 'NAV.PLANNING.ORGANIZATIONOFFICE.TITLE',
                        type        : 'collapsable',
                        icon        : 'supervised_user_circle',
                        children    : 
                        [
                            {
                                id          : 'offices',
                                title       : 'OFFICES',
                                translate   : 'NAV.PLANNING.ORGANIZATIONOFFICE.ORGANIZATIONOFFICE.TITLE',
                                type        : 'item',
                                url         : '/organization-office/list'
                            },
                            {
                                id          : 'offices_add',
                                title       : 'OFFICES_ADD',
                                translate   : 'NAV.PLANNING.ORGANIZATIONOFFICE.ORGANIZATIONOFFICE_ADD.TITLE',
                                type        : 'item',
                                url         : '/organization-office/create'
                            }
                        ]
                    }   
                ]
            },
            {
                id          : 'planear',
                title       : 'PLANEAR',
                translate   : 'NAV.PLANNING.TITLE',
                type        : 'collapsable',
                icon        : 'assignment',
                children:   
                [
                    {
                        id       : 'parafiscal',
                        title    : 'Parafiscales',
                        type     : 'item',  
                        icon     : 'supervised_user_circle',                  
                        url      : '/parafiscal/list',
                    },
                    {
                        id       : 'budget',
                        title    : 'Presupuesto',
                        type     : 'item',
                        icon     : 'attach_money',
                        url      : '/budget/list',
                    },                    
                    {
                        id       : 'budgetTransfer',
                        title    : 'Transferencias',
                        type     : 'item',
                        icon     : 'build',
                        url      : '/budget/transfer/history',
                    },
                    {
                        id          : 'copasst',
                        title       : 'copasst',
                        translate   : 'NAV.PLANNING.COPASST.TITLE',
                        type        : 'collapsable',
                        icon        : 'supervised_user_circle',
                        children    : [
                            {
                                id          : 'members',
                                title       : 'MEMBERS',
                                translate   : 'NAV.PLANNING.COPASST.MEMBERS.TITLE',
                                type        : 'item',
                                url         : '/copasst/member'
                            },
                            {
                                id          : 'members-add',
                                title       : 'MEMBERS_ADD',
                                translate   : 'NAV.PLANNING.COPASST.MEMBERS_ADD.TITLE',
                                type        : 'item',
                                url         : '/copasst/member-create'
                            },                            
                            {
                                id          : 'meetings-list',
                                title       : 'MEETINGS_LIST',
                                translate   : 'NAV.PLANNING.COPASST.MEETINGS_LIST.TITLE',
                                type        : 'item',
                                url         : '/copasst/meeting/list'
                            },
                            {
                                id          : 'meetings',
                                title       : 'MEETINGS',
                                translate   : 'NAV.PLANNING.COPASST.MEETINGS.TITLE',
                                type        : 'item',
                                url         : '/copasst/meeting/create'
                            }                            
                        ]
                    },
                    {
                        id          : 'cocola',
                        title       : 'cocola',
                        translate   : 'NAV.PLANNING.COCOLA.TITLE',
                        type        : 'collapsable',
                        icon        : 'supervised_user_circle',
                        children    : 
                        [
                            {
                                id          : 'members',
                                title       : 'MEMBERS',
                                translate   : 'NAV.PLANNING.COCOLA.MEMBERS.TITLE',
                                type        : 'item',
                                url         : '/cocola/member'
                            },
                            {
                                id          : 'members-add',
                                title       : 'MEMBERS_ADD',
                                translate   : 'NAV.PLANNING.COCOLA.MEMBERS_ADD.TITLE',
                                type        : 'item',
                                url         : '/cocola/member-create'
                            },                                    
                            {
                                id          : 'meetings-list',
                                title       : 'MEETINGS_LIST',
                                translate   : 'NAV.PLANNING.COCOLA.MEETINGS_LIST.TITLE',
                                type        : 'item',
                                url         : '/cocola/meeting/list'
                            },
                            {
                                id          : 'meetings',
                                title       : 'MEETINGS',
                                translate   : 'NAV.PLANNING.COCOLA.MEETINGS.TITLE',
                                type        : 'item',
                                url         : '/cocola/meeting/create'
                            },
                        ]  
                    },
                    {   
                        id          : 'lawmatrix',
                        title       : 'LAWMATRIX',
                        translate   : 'NAV.PLANNING.LAWMATRIX.TITLE',
                        type        : 'collapsable',
                        icon        : 'supervised_user_circle',
                        children    : [
                            {
                                id          : 'articles',
                                title       : 'ARTICLES',
                                translate   : 'NAV.PLANNING.LAWMATRIX.ARTICLES.TITLE',
                                type        : 'item',
                                url         : '/lawmatrix/articles'
                            },
                            {
                                id          : 'add_articles',
                                title       : 'ARTICLES_ADD',
                                translate   : 'NAV.PLANNING.LAWMATRIX.ARTICLES_ADD.TITLE',
                                type        : 'item',
                                url         : '/lawmatrix/articles_add'
                            }
                        ]   
                    },
                    {
                        id          : 'training',
                        title       : 'TRAINING',
                        translate   : 'NAV.PLANNING.TRAINING.TITLE',
                        type        : 'collapsable',
                        icon        : 'supervised_user_circle',
                        children    : [
                            {
                                id          : 'plans',
                                title       : 'PLANS',
                                translate   : 'NAV.PLANNING.TRAINING.PLANS.TITLE',
                                type        : 'item',
                                url         : 'training/plans'
                            },
                            {
                                id          : 'plan_add',
                                title       : 'PLAN_ADD',
                                translate   : 'NAV.PLANNING.TRAINING.PLAN_ADD.TITLE',
                                type        : 'item',
                                url         : 'training/plan_add'
                            }
                        ]
                    },
                    {
                        id          : 'documentstructure',
                        title       : 'DOCUMENTSTRUCTURE',
                        translate   : 'NAV.PLANNING.DOCUMENTSTRUCTURE.TITLE',
                        type        : 'collapsable',
                        icon        : 'supervised_user_circle',
                        children    : [                                    
                            {
                                id          : 'document_add',
                                title       : 'DOCUMENT_ADD',
                                translate   : 'NAV.PLANNING.DOCUMENTSTRUCTURE.DOCUMENT_ADD.TITLE',
                                type        : 'item',
                                url         : '/documentstructure/document_add'
                            }
                        ]
                    },
                    {
                        id          : 'communication-plan',
                        title       : 'communication-plan',
                        translate   : 'NAV.PLANNING.COMMUNICATIONPLAN.TITLE',
                        type        : 'collapsable',
                        icon        : 'supervised_user_circle',
                        children    : [
                            {
                                id          : 'communicationplan',
                                title       : 'COMMUNICATIONPLAN',
                                translate   : 'NAV.PLANNING.COMMUNICATIONPLAN.COMMUNICATIONPLAN.TITLE',
                                type        : 'item',
                                url         : '/communication-plan/list'
                            },
                            {
                                id          : 'communicationplan_add',
                                title       : 'COMMUNICATIONPLAN_ADD',
                                translate   : 'NAV.PLANNING.COMMUNICATIONPLAN.COMMUNICATIONPLAN_ADD.TITLE',
                                type        : 'item',
                                url         : '/communication-plan/create'
                            }
                        ]
                    },
                    {
                        id          : 'communication-aspect',
                        title       : 'communication-aspect',
                        translate   : 'NAV.PLANNING.COMMUNICATIONASPECT.TITLE',
                        type        : 'collapsable',
                        icon        : 'supervised_user_circle',
                        children    : [
                            {
                                id          : 'communicationaspect',
                                title       : 'COMMUNICATIONASPECT',
                                translate   : 'NAV.PLANNING.COMMUNICATIONASPECT.COMMUNICATIONASPECT.TITLE',
                                type        : 'item',
                                url         : '/communication-aspect/list'
                            },
                            {
                                id          : 'communicationaspect_add',
                                title       : 'COMMUNICATIONASPECT_ADD',
                                translate   : 'NAV.PLANNING.COMMUNICATIONASPECT.COMMUNICATIONASPECT_ADD.TITLE',
                                type        : 'item',
                                url         : '/communication-aspect/create'
                            }
                        ]
                    },  
                    {
                        id          : 'evaluation-rate',
                        title       : 'evaluation-rate',
                        translate   : 'NAV.PLANNING.EVALUATIONRATE.TITLE',
                        type        : 'collapsable',
                        icon        : 'supervised_user_circle',
                        children    : [
                            {
                                id          : 'evaluationrate',
                                title       : 'EVALUATIONRATE',
                                translate   : 'NAV.PLANNING.EVALUATIONRATE.EVALUATIONRATE.TITLE',
                                type        : 'item',
                                url         : '/evaluation-rate/list'
                            },
                            {
                                id          : 'evaluationrate_add',
                                title       : 'EVALUATIONRATE_ADD',
                                translate   : 'NAV.PLANNING.EVALUATIONRATE.EVALUATIONRATE_ADD.TITLE',
                                type        : 'item',
                                url         : '/evaluation-rate/create'
                            }
                        ]
                    },
                    {   
                        id          : 'participationmechanism',
                        title       : 'Mecanismos de participación',
                        type        : 'collapsable',
                        icon        : 'supervised_user_circle',
                        children    : [
                            {
                                id          : 'participationmechanismcreate',
                                title       : 'Mecanismos de participación',
                                type        : 'item',
                                url         : '/participation-mechanism/list'
                            },  
                            {
                                id          : 'participation-mechanism-type',
                                title       : 'Tipos de mecanismos de participación',
                                type        : 'item',
                                url         : '/participation-mechanism/type'
                            }
                        ]   
                    }, 
                    {
                        id          : 'subtypes',
                        title       : 'SUBTYPES',
                        translate   : 'NAV.PLANNING.MEDICALEVALUATION.SUBTYPES.TITLE',
                        type        : 'item',
                        url         : '/medical-evaluation/subtype/list'
                    },
                    {
                        id          : 'subtypes_add',
                        title       : 'SUBTYPES_ADD',
                        translate   : 'NAV.PLANNING.MEDICALEVALUATION.SUBTYPES_ADD.TITLE',
                        type        : 'item',
                        url         : '/medical-evaluation/subtype/create'
                    }                     
                ]
            },
            {
                id          : 'make',
                title       : 'MAKE',
                translate   : 'NAV.MAKE.TITLE',
                type        : 'collapsable',
                icon        : 'assignment',
                children:   [
                    {   
                        id          : 'environmentmeasure',
                        title       : 'Mediciones Ambientales',
                        type        : 'collapsable',
                        icon        : 'supervised_user_circle',
                        children    : [
                            {
                                id          : 'environment-measure-type',
                                title       : 'Tipos',
                                type        : 'item',
                                url         : '/environment-measure/type'
                            },
                            {
                                id          : 'environmentmeasurecreate',
                                title       : 'Programar',
                                type        : 'item',
                                url         : '/environment-measure/list'
                            },
                            {
                                id          : 'result',
                                title       : 'Resultados',
                                type        : 'item',
                                url         : '/environment-measure/result/list'
                            },
                            {
                                id          : 'param',
                                title       : 'Parametros biomecanicos',
                                type        : 'item',
                                url         : '/environment-measure/param/list'
                            }
                        ]   
                    },
                    {
                        id          : 'medical-evaluation',
                        title       : 'medical-evaluation',
                        translate   : 'NAV.PLANNING.MEDICALEVALUATION.TITLE',
                        type        : 'collapsable',
                        icon        : 'supervised_user_circle',
                        children    : [                            
                            {
                                id          : 'evaluation',
                                title       : 'EVALUATION',
                                translate   : 'NAV.PLANNING.MEDICALEVALUATION.EVALUATION.TITLE',
                                type        : 'item',
                                url         : '/medical-evaluation/evaluation/list'
                            },
                            {
                                id          : 'evaluation_add',
                                title       : 'EVALUATION_ADD',
                                translate   : 'NAV.PLANNING.MEDICALEVALUATION.EVALUATION_ADD.TITLE',
                                type        : 'item',
                                url         : '/medical-evaluation/evaluation/create'
                            }
                        ]
                    },
                    {
                        id          : 'copasst-meeting',
                        title       : 'copasst-meeting',
                        translate   : 'NAV.PLANNING.COPASST.TITLE',
                        type        : 'collapsable',
                        icon        : 'supervised_user_circle',
                        children    : [                            
                            {
                                id          : 'execute-meeting',
                                title       : 'execute-meeting',
                                translate   : 'NAV.PLANNING.COPASST.MEETINGS_EXECUTE.TITLE',
                                type        : 'item',
                                url         : '/copasst/meeting/execute'
                            }
                        ]
                    },
                    {
                        id          : 'cocola-meeting',
                        title       : 'cocola-meeting',
                        translate   : 'NAV.PLANNING.COCOLA.TITLE',
                        type        : 'collapsable',
                        icon        : 'supervised_user_circle',
                        children    : [                            
                            {
                                id          : 'execute-meeting',
                                title       : 'execute-meeting',
                                translate   : 'NAV.PLANNING.COCOLA.MEETINGS_EXECUTE.TITLE',
                                type        : 'item',
                                url         : '/cocola/meeting/execute'
                            }
                        ]
                    },
                    {
                        id          : 'personal-protection-a',
                        title       : 'Protección personal',
                        translate   : '',
                        type        : 'collapsable',
                        icon        : 'supervised_user_circle',
                        children    : [                            
                            {
                                id          : 'personal-protection-elements',
                                title       : 'Elementos',
                                type        : 'item',
                                url         : '/personal-protection-element/list'
                            },
                            {
                                id          : 'personal-protection-types',
                                title       : 'Tipos',
                                type        : 'item',
                                url         : '/personal-protection-element/type/list'
                            }
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
