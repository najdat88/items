import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'Items',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44324/',
    redirectUri: baseUrl,
    clientId: 'Items_App',
    responseType: 'code',
    scope: 'offline_access Items',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44324',
      rootNamespace: 'Najd.Md.Items',
    },
    Items: {
      url: 'https://localhost:44343',
      rootNamespace: 'Najd.Md.Items',
    },
  },
} as Environment;
