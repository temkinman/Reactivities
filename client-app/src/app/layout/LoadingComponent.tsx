import React from "react";
import { Dimmer, Loader } from "semantic-ui-react";

interface Props {
    content: string;
}

export default function LoadingComponent({content = 'Loading...'}: Props) {
    return (
        <Dimmer active={true} >
            <Loader content={content}/>
        </Dimmer>
    )
}

