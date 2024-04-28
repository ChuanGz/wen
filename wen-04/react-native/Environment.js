const yourIP = 'localhost'; // See the docs https://docs.abp.io/en/abp/latest/Getting-Started-React-Native?Tiered=No
const port = 44305;
const apiUrl = `http://${yourIP}:${port}`;
const ENV = {
  dev: {
    apiUrl: apiUrl,
    oAuthConfig: {
      issuer: apiUrl,
      clientId: 'ReactNative_App',
      scope: 'offline_access ReactNative',
    },
    localization: {
      defaultResourceName: 'ReactNative',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44342',
    oAuthConfig: {
      issuer: 'http://localhost:44342',
      clientId: 'ReactNative_App',
      scope: 'offline_access ReactNative',
    },
    localization: {
      defaultResourceName: 'ReactNative',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
