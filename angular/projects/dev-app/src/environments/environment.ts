import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'MicroservicesDemo',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44340',
    redirectUri: baseUrl,
    clientId: 'MicroservicesDemo_App',
    responseType: 'code',
    scope: 'offline_access MicroservicesDemo role email openid profile',
  },
  apis: {
    default: {
      url: 'https://localhost:44340',
      rootNamespace: 'MicroservicesDemo',
    },
    MicroservicesDemo: {
      url: 'https://localhost:44370',
      rootNamespace: 'MicroservicesDemo',
    },
  },
} as Environment;
