#! /bin/bash
name=$1
folder=${2:-"Pages"}

mkdir -p $folder
cat <<EOF > $folder/$name.razor
@page "/${name}"

<h3>${name}</h3>

<p>This is the ${name} page.</p>
EOF


# ./make-razor-page.sh Demo
