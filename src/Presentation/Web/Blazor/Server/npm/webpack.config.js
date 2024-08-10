//dev.to/antonmelnyk/how-to-configure-webpack-from-scratch-for-a-basic-website-46a5

// Webpack uses this to work with directories
const path = require('path');
const MiniCssExtractPlugin = require("mini-css-extract-plugin");
// This is the main configuration object.
// Here, you write different options and tell Webpack what to do
module.exports = {
    module: {
        rules: [
            {
                test: /\.js$/,
                exclude: /(node_modules)/,
                use: {
                    loader: 'babel-loader',
                    options: {
                        presets: ['@babel/preset-env']
                    }
                }
            },
            {
                test: /\.(sa|sc|c)ss$/,
                // Set loaders to transform files.
                // Loaders are applying from right to left(!)
                // The first loader will be applied after others
                use: [
                    {
                        // After all CSS loaders, we use a plugin to do its work.
                        // It gets all transformed CSS and extracts it into separate
                        // single bundled file
                        loader: MiniCssExtractPlugin.loader
                    }, 
                    {
                        // This loader resolves url() and @imports inside CSS
                        loader: "css-loader",
                    }
                ]
            },
        ],
    },
    plugins: [

        new MiniCssExtractPlugin({
            filename: "index.bundle.css"
        })

    ],
    // Path to your entry point. From this file Webpack will begin its work
    entry: './src/index.js',

    // Path and filename of your result bundle.
    // Webpack will bundle all JavaScript into this file
    output: {
        path: path.resolve(__dirname, '../wwwroot/dist'),
        publicPath: '',
        filename: 'index.bundle.js'
    }
};