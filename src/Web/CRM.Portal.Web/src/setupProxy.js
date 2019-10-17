const proxy = require('http-proxy-middleware');

module.exports = function(app) {
  app.use(proxy('/authority', {
    target: 'http://localhost:5101/identity',
    changeOrigin: true,
    pathRewrite: {
      '^/authority': ''
    }
  }));
};
