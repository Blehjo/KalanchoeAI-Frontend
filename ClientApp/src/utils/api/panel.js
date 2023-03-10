import axios from "axios";

const api = "https://kalanchoeai-server.azurewebsites.net/api/panel";

const headers = {
  'Accept': 'application/json',
  'Content-Type': 'application/json' 
}

export async function getSinglePanel(panelId) {
  return await axios({
    method: 'get',
    url: `${api}/${panelId}`,
    config: headers,
    withCredentials: true
  });
}

export async function getPanels() {
  return await axios({
    method: 'get',
    url: api, 
    config: headers,
    withCredentials: true
  });
}

export async function getUserPanelsProfile(id) {
  return await axios({
    method: 'get',
    url: `${api}/user/${id}`,
    config: headers,
    withCredentials: true
  });
}

export async function getUserPanels() {
  return await axios({
    method: 'get',
    url: `${api}/users`, 
    config: headers,
    withCredentials: true
  });
}

export async function addPanel(panel) {
  return await axios({
    method: 'post',
    url: api,
    data: {
      title: panel.value
    },
    config: headers,
    withCredentials: true
  })
}

export async function editPanel(panel) {
  return await axios({
    method: 'put',
    url: `${api}/${panel.id}`,
    data: panel,
    config: headers,
    withCredentials: true
  });
}

export async function deletePanel(panelId) {
  return await axios({
    method: 'delete',
    url: `${api}/${panelId}`,
    config: headers,
    withCredentials: true
  });
}