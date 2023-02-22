import { useEffect } from "react";
import { useNavigate } from "react-router-dom";
import { deletePost, editPost, getPosts } from "../utils/api/post";
import { Button, Row, Col, Card } from "react-bootstrap";
import { useDispatch, useSelector } from "react-redux";
import { selectCurrentUser } from "../store/user/user.selector";
import { selectPosts } from "../store/post/post.selector";
import { postFetchAllStart } from "../store/post/post.action";

const FetchedPosts = () => {
    const dispatch = useDispatch();
    const currentUser = useSelector(selectCurrentUser);
    const posts = useSelector(selectPosts);
    const navigate = useNavigate();

    const clearPost = async (event) => {
        const id = event.target.id;
        deletePost(id);
    }

    const updatePost = async (event) => {
        const id = event.target.id;
        editPost();
    }

    const goToPost = async (event) => {
        const id = event.target.id;
        navigate(`/posts/${id}`);
    }

    useEffect(() => {
        getPosts()
        .then((response) => dispatch(postFetchAllStart(response.data)));
    }, []);

    return (
        <Row xl={4} style={{ marginTop: '1rem' }}>
            {
                posts?.length > 0 && posts?.map(({ postValue, postId, mediaLink, userId }) => (
                    <Col onClick={goToPost} key={postId}>
                        {mediaLink?.length > 0 ? <Card.Img height='200' style={{ objectFit:'cover'}} src={mediaLink}/> : ''}
                        <Card.Title style={{ margin: 'auto' }}>{postValue}</Card.Title>
                        <Button variant="light" onClick={goToPost} as="input" type="button" value="Go to Post" id={postId}/>
                        {currentUser && <Button variant="light" as="input" type="button" value="Delete" onClick={clearPost} id={postId}/>}
                        {currentUser && <Button variant="light" as="input" type="button" value="Edit" onClick={updatePost} id={postId}/>}  
                    </Col>
                ))
            }
        </Row>
    )
}

export default FetchedPosts;