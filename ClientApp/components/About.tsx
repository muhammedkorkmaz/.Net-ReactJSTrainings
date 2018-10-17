import * as React from 'react';
import { RouteComponentProps } from 'react-router';

export class About extends React.Component<RouteComponentProps<{}>, {}> {

    public render(){

        return (
            <div>
                <h1>Hi, I am Muhammed Korkmaz</h1>
                <p>This is my first .net app with react js.</p>
                <p>This code is writen by Intelij IDE</p>
            </div>
        );
    }
    
}
