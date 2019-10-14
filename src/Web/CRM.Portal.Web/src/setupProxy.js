const proxy = require('http-proxy-middleware');

module.exports = function(app) {
  app.use(proxy('/authority', {
    target: 'http://localhost:5101',
    changeOrigin: true,
    pathRewrite: {
      '^/authority': ''
    }
  }));

  app.use(proxy('/graphqlAPI', {
    target: 'http://localhost:58134/graphql',
    changeOrigin: true,
    pathRewrite: {
      '^/graphqlAPI': ''
    }
  }));
};
