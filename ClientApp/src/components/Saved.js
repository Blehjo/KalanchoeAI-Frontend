import { Nav } from 'react-bootstrap';
import { Collection, House, Database, Eye, Clipboard, Bookmark, ChatDots, Person, PersonWorkspace, Newspaper, Robot } from 'react-bootstrap-icons';
import { Fragment, useEffect, useState } from 'react';
import { getUser } from '../utils/userDocument';

const Saved = () => {
    const [userId, setUserId] = useState(null);

    useEffect(() => {
        getUser()
        .then((response) => setUserId(response.data.userId));
    }, []);

    return (
        <Fragment>
            <Nav.Link href="/profile">
                <Person className='mt-4' color="black" size={40} />
            </Nav.Link>
            <Nav.Link href={`/page/${userId}`}>
                <House className='mt-4' color="black" size={40}/>
            </Nav.Link>
            <Nav.Link href="/artoo">
                <Robot className='mt-4' color="black" size={40} />
            </Nav.Link>
            <Nav.Link href="/messages">
                <ChatDots className='mt-4' color="black" size={40} />
            </Nav.Link>
            <Nav.Link href="/dashboard">
                <PersonWorkspace className='mt-4' color="black" size={40} />
            </Nav.Link>
            <Nav.Link href="/projects">
                <Clipboard className='mt-4' color="black" size={40} />
            </Nav.Link>
            <Nav.Link href="/explore">
                <Eye className='mt-4' color="black" size={40} />
            </Nav.Link>
            <Nav.Link href="/communities">
                <Database className='mt-4' action='true' color="black" size={40} />
            </Nav.Link>
            <Nav.Link href="/saved">
                <Bookmark className='mt-4' color="black" size={40} />
            </Nav.Link>
            <Nav.Link href="/news">
                <Newspaper className='mt-4' color="black" size={40} />
            </Nav.Link>
            <Nav.Link href="/posts">
                <Collection className='mt-4' color="black" size={40} />
            </Nav.Link>
        </Fragment>
    )
}

export default Saved;